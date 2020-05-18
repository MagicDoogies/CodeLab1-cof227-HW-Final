using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class DataParser : MonoBehaviour
{
    public GameObject[] tileSet; //Store our tile prefabs

    public string fileLevel;//public field to place the text file in.

    public GameObject RedGem;
    public GameObject GreenGem;
    public GameObject PurpleGem;


    // Start is called before the first frame update
    void Start()
    {
        //string fullFilePath = Application.dataPath + "/" + fileLevel;
        //LoadTiles();
        string path = Application.dataPath + "/" + fileLevel;
        print(path);

        if (File.Exists(path))
        {
            print("File found and read");

            string[] lines = File.ReadAllLines(path); // read each line of the text document as a string

            for (int y = 0; y < lines.Length; y++)
            {
                string line = lines[y]; //get each line

                char[] characters = line.ToCharArray();

                //go through each character on the current line
                for (int x = 0; x < characters.Length; x++)
                {
                    GameObject newObject;

                    switch (characters[x])
                    {//This entire section is dedicated to assigning a letter to all existing tilesets in the Tile Set array.
                        case 'P':
                            GameObject ground = Instantiate(tileSet[8]);//Spawns player AND 'GrassTile1'
                            newObject = Instantiate(tileSet[0]);
                            ground.transform.position = new Vector2(x, y);
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'A':
                            newObject = Instantiate(tileSet[10]);//spawns 'RoomBorder 2'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'B':
                            newObject = Instantiate(tileSet[12]);//spawns 'RoomBoarder 1'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'C':
                            newObject = Instantiate(tileSet[14]);//spawns 'Wall1'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'D':
                            newObject = Instantiate(tileSet[15]);//spawns 'Wall2'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'E':
                            newObject = Instantiate(tileSet[8]);//spawns 'GrassTile1' 
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'F':
                            newObject = Instantiate(tileSet[9]);//spawns 'GrassTile2'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'G':
                            newObject = Instantiate(tileSet[1]);//spawns 'Dirtpath1'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'H':
                            newObject = Instantiate(tileSet[2]);//spawns 'Dirtpath2'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'I':
                            newObject = Instantiate(tileSet[3]);//spawns 'Flowertile1'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'J':
                            newObject = Instantiate(tileSet[4]);//spanws 'FlowerTile2'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'K':
                            newObject = Instantiate(tileSet[5]); //spawns 'FlowerTile3'
                            newObject.transform.position = new Vector2(x, y);
                            break;

                        case 'L':
                            newObject = Instantiate(tileSet[6]);//spawns 'FlowerTile4'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'M':
                            newObject = Instantiate(tileSet[7]);//spawns 'FlowerTile 5'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'N':
                            GameObject ground2 = Instantiate(tileSet[8]);//spawns another 'GrassTile2' under the column sprite.
                            ground2.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[13]);//spawns 'StoneColumn'
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'O':
                            newObject = Instantiate(tileSet[3]);
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        //these sets of tiles spawn the items
                        case 'X':
                            GameObject statueGround = Instantiate(tileSet[7]);//spawns flowertile 5
                            statueGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[23]);//spawns the statue
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'Q':
                            GameObject SproutGround = Instantiate(tileSet[8]);
                            SproutGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[24]);//spawns sprout
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'R':
                            GameObject SlugGround = Instantiate(tileSet[1]);
                            SlugGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[16]);//spans the slug
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'S':
                            GameObject RedGround = Instantiate(tileSet[8]);
                            RedGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[17]);//spawns the Red Gem
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'T':
                              GameObject PurpleGround = Instantiate(tileSet[8]);
                              PurpleGround.transform.position = new Vector2(x, y);
                              newObject = Instantiate(tileSet[18]);//spawns the purple Gem
                              newObject.transform.position = new Vector2(x, y);
                          
                            break;
                        case 'U':
                            GameObject GreenGround = Instantiate(tileSet[8]);
                            GreenGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[19]);//spawns the Green gem
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'V':
                            GameObject FlyGround = Instantiate(tileSet[2]);
                            FlyGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[20]);//spawns the Fly
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'W':
                            GameObject CharmGround = Instantiate(tileSet[4]);
                            CharmGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[21]);//spawns the charm
                            newObject.transform.position = new Vector2(x, y);

                            break;
                        case 'Z':
                            GameObject BeansGround = Instantiate(tileSet[4]);
                            BeansGround.transform.position = new Vector2(x, y);
                            newObject = Instantiate(tileSet[22]);//spawns the beans
                            newObject.transform.position = new Vector2(x, y);

                            break;


                        default:
                            print("empty");
                            break;
                    }
                }
            }
        }

    }

    private void LoadTiles() //Reads and loads the JSON file to store the tiles into the 'TileList' array.
    {
        //string path = Path.Combine(Application.streamingAssetsPath, "Level.txt"); //This tells Unity where to find the JSON file within the root folders of the project.
        //string path = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Assets","Level.txt");

       

    }
}
