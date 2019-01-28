using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using System.IO;


public class DataManager
{

    /*
    //public ShipBase ship;
    //private ShipBase _tmpShip;

    private string _fileName;
    
    public string fileName
    {
        get { return _fileName; }
        set { _fileName = value; }
    }
    

    private static DataManager instance;
    private DataManager()
    {
        //ship = new ShipBase();
        //_tmpShip = new ShipBase();

        
    }

    public static DataManager GetDataManager()
    {
        if (instance == null)
        {
            instance = new DataManager();
        }

        return instance;
    }



    //写入数据
    public bool SaveData()
    {
        MemoryStream ms = new MemoryStream();
        BinaryWriter bw = new BinaryWriter(ms);
        WriteData(bw);





        if (!SaveLocalDataFile(_fileName, ms.ToArray())){
            bw.Close();
            return false;
        }
        else
        {
            bw.Close();
            return true;
        }
    }


    //读取数据
    public void LoadData()
    {
        byte[] data = GetLocalDataFile(_fileName);
        if (data == null)
        {
            return;
        }
        MemoryStream ms = new MemoryStream();
        BinaryReader br = new BinaryReader(ms);
        ReadData(br);
        //byte[] data=
    }



    //存储文件
    bool SaveLocalDataFile(string FileName,byte[] data)
    {
        string path = Application.dataPath + "/data/" + FileName;
        FileStream fs;
        if (File.Exists(path))
        {
            //File.Delete(path);
            fs = new FileStream(path, FileMode.Create);
            if (fs==null)
            {
                return false;
            }
            
        }
        else
        {
            fs = new FileStream(path, FileMode.Create);
        }
        fs.Write(data, 0, data.Length);
        fs.Close();
        return true;

        //return false;
    }

    
    //读取文件
    public byte[] GetLocalDataFile(string filename)
    {
        //byte[] data =  ;
        string path = Application.dataPath + "/data/" + filename;
        if (!File.Exists(path))
        {
            FileStream fs = new FileStream(path, FileMode.CreateNew);
        }
        else
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            fs.Write(data, 0, data.Length);
        }
        

        byte[] data;
    }


    private void WriteData(BinaryWriter binaryWriter)
    {
        //binaryWriter.Write
    }

    private void ReadData(BinaryReader binaryReader)
    {

    }
    
    */

    
}

