using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildLevelFromFile : MonoBehaviour
{

    /// <summary>
    /// Método llamado cuando se selecciona la opción del editor.
    /// </summary>
    [MenuItem("Level/Build level")]
    public static void buildLevel()
    {
        var path = EditorUtility.OpenFilePanel("Selecciona fichero de texto", "", "txt");

        if (path.Length == 0)
            return;

        if (!CheckEmptyRootNode())
            return;

        initPrefabsBD();

        GameObject root = GameObject.Find("Level");

        try
        {
            int y = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    var c = line[x];
                    if (c == ' ')
                        continue;

                    if (!prefabs.ContainsKey(c))
                    {
                        Debug.LogError("Caracter '" + c + "' no entendido en (" + (x + 1) + ", " + (y + 1) + ").");
                        continue;
                    }

                    // Otras cosas
                    Object prefab = prefabs[c];
                    if (prefab != null)
                    {
                        GameObject o = createObject(prefab, root, new Vector3((float)x / 2 - 0.5f, -((float)y / 2 - 0.5f), 0));
                    }
                }

                y++;
            }
            file.Close();
        }
        catch (IOException)
        {
            Debug.LogError("Error de lectura del fichero " + path + ".");
        }
    }

    private static bool CheckEmptyRootNode()
    {
        // Sacamos la raíz de la escena
        GameObject sceneRoot = GameObject.Find("Level");

        if (sceneRoot == null)
        {
            sceneRoot = new GameObject();
            sceneRoot.name = "Level";
        }

        if (sceneRoot.transform.childCount > 0)
        {
            if (!EditorUtility.DisplayDialog("Confirmación", "El GameObject 'Level' no está vacio. ¿Continuar?", "Sí", "No"))
                return false;
        }

        return true;
    }


    private struct PrefabInfo
    {
        public char code;
        public string file;
        public PrefabInfo(char c, string f) { code = c; file = f; }
    }

    static PrefabInfo[] all = new PrefabInfo[] {
        new PrefabInfo('1', "Assets/Prefabs/2DPlayer1.prefab"),
        new PrefabInfo('2', "Assets/Prefabs/2DPlayer2.prefab"),
        new PrefabInfo('3', "Assets/Prefabs/2DPlayerSolo.prefab"),
        new PrefabInfo('M', "Assets/Prefabs/Muro.prefab"),
        new PrefabInfo('l', "Assets/Prefabs/Muro.prefab"), // para el de luz
        new PrefabInfo('d', "Assets/Prefabs/Muro.prefab"), // para el de oscuridad
        new PrefabInfo('B', "Assets/Prefabs/Botones/BotonUnClick.prefab"),
        new PrefabInfo('L', "Assets/Prefabs/Botones/BotonUnClickLuz.prefab"), // el de luz
        new PrefabInfo('D', "Assets/Prefabs/Botones/BotonUnClickOscuro.prefab"), // el de oscuro
        new PrefabInfo('b', "Assets/Prefabs/Botones/BotonMantener.prefab"),
        new PrefabInfo('u', "Assets/Prefabs/Botones/BotonMantenerLuz.prefab"), // el de luz
        new PrefabInfo('s', "Assets/Prefabs/Botones/BotonMantenerOscuro.prefab"), // el de oscuridad
        new PrefabInfo('D', "Assets/Prefabs/Botones/BotonDoble.prefab"), // doble un click
        new PrefabInfo('d', "Assets/Prefabs/Botones/BotonDobleMantenido.prefab"), // doble mantenido
    };
    static Dictionary<char, Object> prefabs;
    private static void initPrefabsBD()
    {
        if (prefabs == null)
            prefabs = new Dictionary<char, Object>();
        foreach (var info in all)
            addPrefab(info.code, info.file);
    }

    private static void addPrefab(char key, string prefabName)
    {
        if (prefabs.ContainsKey(key))
            // La BD ya está inicializada (por otra invocación a la opción del menú)
            return;

        Object prefab = AssetDatabase.LoadAssetAtPath(prefabName, typeof(GameObject));
        if (prefab == null)
        {
            Debug.LogError("Prefab " + prefabName + " no encontrado.");
            return;
        }
        prefabs.Add(key, prefab);
    }

    /// <summary>
    /// Instancia el prefab en la posición indicada; el objeto creado será
    /// hijo del objeto recibido como parámetro.
    /// </summary>
    /// <param name="prefab"></param>
    /// <param name="parent"></param>
    /// <param name="pos"></param>
    static GameObject createObject(Object prefab, GameObject parent, Vector3 pos)
    {
        GameObject go;
        go = PrefabUtility.InstantiatePrefab(prefab) as GameObject;
        go.transform.position = pos;
        go.transform.rotation = Quaternion.identity;
        go.transform.parent = parent.transform;
        return go;
    }
}