using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VLG
{
    // Floors 11-20
    public static class Floors11_20
    {
        // Gets the floor
        public static Floor GetFloor(int id)
        {
            // The floor object.
            Floor floor = null;

            // Gets the floor based on the ID.
            switch (id)
            {
                default:
                case 1:
                case 11:
                    floor = GetFloor01();
                    break;

                case 2:
                case 12:
                    floor = GetFloor02();
                    break;

                case 3:
                case 13:
                    floor = GetFloor03();
                    break;

                case 4:
                case 14:
                    floor = GetFloor04();
                    break;

                case 5:
                case 15:
                    floor = GetFloor05();
                    break;

                case 6:
                case 16:
                    floor = GetFloor06();
                    break;

                case 7:
                case 17:
                    floor = GetFloor07();
                    break;

                case 8:
                case 18:
                    floor = GetFloor08();
                    break;

                case 9:
                case 19:
                    floor = GetFloor09();
                    break;

                case 10:
                case 20:
                    floor = GetFloor10();
                    break;
            }

            return floor;
        }

        // Floor 01
        public static Floor GetFloor01()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 11;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "00A", "00A", "00A", "00A", "00A", "00A", "01A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "02A", "00A", "00A", "00A", "00A", "00A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 16;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 02
        public static Floor GetFloor02()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 12;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "02D"},
                { "03A", "00A", "00A", "00A", "00A", "00A", "03A", "00A", "08B", "08A"},
                { "03A", "00A", "00A", "00A", "00A", "03A", "03A", "03A", "03A", "03A"},
                { "03A", "00A", "00A", "00A", "03A", "03A", "00A", "03A", "00A", "03A"},
                { "03A", "00A", "00A", "00A", "09B", "00A", "00A", "03A", "00A", "03A"},
                { "03A", "00A", "00A", "03A", "03A", "07D", "00A", "03A", "00A", "03A"},
                { "03A", "00A", "00A", "03A", "00A", "03A", "03A", "03A", "00A", "07D"},
                { "03A", "00A", "03A", "03A", "00A", "00A", "00A", "03A", "03A", "03A"},
                { "03A", "00A", "03A", "00A", "00A", "00A", "00A", "00A", "00A", "03A"},
                { "01A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 20;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 03
        public static Floor GetFloor03()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 13;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "02A"},
                { "08A", "08B", "08A", "08B", "08A", "08A", "08B", "08B", "08A", "08A"},
                { "08A", "08B", "08A", "08A", "08A", "08B", "08B", "08A", "08A", "08B"},
                { "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A"},
                { "08A", "08A", "08B", "08A", "08B", "08B", "08B", "08B", "08B", "08A"},
                { "08A", "08B", "08A", "08A", "08B", "08A", "08B", "08A", "08A", "08A"},
                { "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A"},
                { "08B", "08A", "08B", "08A", "08B", "08B", "08A", "08A", "08A", "08A"},
                { "08A", "08B", "08A", "08B", "08A", "08B", "08A", "08B", "08A", "08B"},
                { "01A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 24;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 04
        public static Floor GetFloor04()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 14;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "00A", "00A", "03A", "05A", "05A", "05A", "05A", "05A", "05A", "05A"},
                { "00A", "00A", "03A", "00A", "05B", "00A", "05B", "00A", "00A", "05A"},
                { "00A", "00A", "03A", "05A", "05A", "00A", "05A", "05A", "00A", "05A"},
                { "00A", "00A", "03A", "00A", "00A", "00A", "05B", "00A", "00A", "05A"},
                { "02D", "01A", "03A", "05A", "05A", "05A", "05A", "05A", "05A", "09B"},
                { "00A", "00A", "03A", "00A", "00A", "00A", "05B", "00A", "00A", "05A"},
                { "00A", "00A", "03A", "05A", "05A", "05A", "05A", "05A", "00A", "05A"},
                { "00A", "00A", "03A", "00A", "05B", "00A", "05B", "00A", "00A", "05A"},
                { "00A", "00A", "03A", "00A", "05B", "00A", "05B", "05A", "00A", "05A"},
                { "00A", "00A", "03A", "05A", "05A", "05A", "05A", "05A", "05A", "05A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 28;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 05
        public static Floor GetFloor05()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 15;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "03A", "03A", "03A", "03A", "03A", "03A", "02A", "03A", "03A", "03A"},
                { "03A", "00A", "03A", "00A", "03A", "07E", "03A", "00A", "03A", "03A"},
                { "03A", "00A", "03A", "00A", "00A", "00A", "03A", "00A", "03A", "03A"},
                { "03A", "00A", "03A", "00A", "00A", "00A", "03A", "00A", "03A", "07C"},
                { "03A", "00A", "00A", "00A", "07E", "00A", "03A", "00A", "03A", "00A"},
                { "07D", "00A", "00A", "07D", "03A", "00A", "03A", "00A", "03A", "00A"},
                { "07A", "07B", "07C", "03A", "03A", "00A", "03A", "00A", "03A", "00A"},
                { "03A", "03A", "03A", "03A", "03A", "00A", "03A", "00A", "07A", "00A"},
                { "03A", "03A", "03A", "03A", "03A", "00A", "07B", "00A", "00A", "00A"},
                { "01A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A", "03A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 14;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 06
        public static Floor GetFloor06()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 16;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "00A", "00A", "09B", "00A", "09E", "00A", "09E", "00A", "00A", "00A"},
                { "00A", "00A", "05B", "00A", "05B", "00A", "05B", "00A", "00A", "00A"},
                { "00A", "00A", "05B", "00A", "05B", "00A", "05B", "00A", "00A", "00A"},
                { "00A", "00A", "05B", "05A", "05B", "05A", "05B", "00A", "00A", "00A"},
                { "00A", "00A", "05A", "00A", "05B", "00A", "05A", "00A", "00A", "00A"},
                { "00A", "00A", "09E", "00A", "09B", "00A", "09B", "00A", "00A", "00A"},
                { "00A", "00A", "05B", "05A", "05B", "05A", "05B", "00A", "00A", "00A"},
                { "00A", "00A", "05B", "00A", "05B", "00A", "05B", "00A", "00A", "00A"},
                { "00A", "00A", "05B", "00A", "05B", "00A", "05B", "00A", "00A", "00A"},
                { "07A", "01A", "03A", "03A", "03A", "03A", "03A", "00A", "02D", "07A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 26;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 07
        public static Floor GetFloor07()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 17;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "00A", "03A", "00A", "00A", "02A", "00A", "00A", "00A", "03A", "00A"},
                { "03A", "07B", "00A", "03A", "03A", "03A", "00A", "03A", "07E", "09D"},
                { "09C", "03A", "00A", "04A", "06B", "07A", "03A", "00A", "03A", "00A"},
                { "00A", "03A", "00A", "03A", "03A", "00A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "03A", "00A", "03A", "00A", "03A", "07A"},
                { "00A", "00A", "00A", "00A", "03A", "00A", "03A", "00A", "00A", "00A"},
                { "00A", "09C", "00A", "00A", "03A", "00A", "03A", "00A", "00A", "00A"},
                { "00A", "03A", "00A", "03A", "01A", "03A", "03A", "00A", "03A", "00A"},
                { "03A", "07C", "00A", "03A", "03A", "03A", "03A", "00A", "07D", "03A"},
                { "00A", "03A", "00A", "07B", "07C", "07D", "07E", "00A", "09D", "00A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 18;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 08
        public static Floor GetFloor08()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 18;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "03A", "03A", "07D", "03A", "03A", "03A", "03A", "07B", "03A", "01A"},
                { "00A", "07A", "00A", "03A", "00A", "03A", "00A", "00A", "03A", "00A"},
                { "00A", "03A", "00A", "03A", "03A", "07E", "03A", "03A", "03A", "00A"},
                { "00A", "03A", "00A", "00A", "00A", "03A", "00A", "00A", "07D", "00A"},
                { "03A", "03A", "03A", "03A", "03A", "03A", "00A", "00A", "03A", "00A"},
                { "00A", "03A", "00A", "00A", "00A", "03A", "00A", "00A", "03A", "00A"},
                { "03A", "03A", "07C", "03A", "07B", "03A", "03A", "07C", "03A", "03A"},
                { "00A", "00A", "00A", "03A", "00A", "00A", "00A", "00A", "03A", "00A"},
                { "02A", "07A", "03A", "03A", "03A", "03A", "03A", "03A", "07E", "00A"},
                { "00A", "00A", "00A", "03A", "00A", "00A", "00A", "00A", "03A", "00A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 12;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 09
        public static Floor GetFloor09()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 19;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "08B", "08B", "08B", "09B", "06A", "06A", "09C", "04A", "04A", "00A"},
                { "08A", "08A", "08B", "09D", "06B", "06A", "09C", "04A", "04B", "00A"},
                { "08A", "08A", "08A", "09D", "06A", "06A", "09C", "04A", "04B", "00A"},
                { "08A", "08A", "08A", "09D", "06A", "06B", "09C", "04A", "04A", "04A"},
                { "01A", "08A", "08B", "09D", "06A", "06A", "09C", "04A", "04A", "02D"},
                { "08B", "08A", "08B", "09D", "06B", "06A", "09C", "04B", "04B", "04B"},
                { "08B", "08B", "08B", "09D", "06B", "06B", "09C", "04A", "04B", "00A"},
                { "08A", "08A", "08A", "09D", "06A", "06B", "09C", "04B", "04A", "00A"},
                { "08A", "08B", "08A", "09B", "06B", "06A", "09C", "04A", "04B", "00A"},
                { "08B", "08A", "08B", "09D", "06B", "06B", "09C", "04B", "04A", "00A"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 30;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }

        // Floor 10
        public static Floor GetFloor10()
        {
            Floor floor = new Floor();

            // ID and Code
            floor.id = 20;
            floor.code = FloorData.Instance.GetFloorCode(floor.id);

            // Geometry
            string[,] geometry = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS]{
                { "09C", "03A", "00A", "00A", "00A", "02D", "00A", "00A", "03A", "09D"},
                { "00A", "03A", "05A", "00A", "00A", "04A", "00A", "03A", "03A", "00A"},
                { "00A", "00A", "03A", "03A", "00A", "06B", "03A", "03A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "08B", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "03A", "03A", "03A", "03A", "03A", "09B"},
                { "09B", "03A", "03A", "03A", "03A", "03A", "03A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "03A", "03A", "00A", "03A", "03A", "00A", "00A"},
                { "00A", "00A", "03A", "03A", "03A", "00A", "00A", "03A", "05B", "00A"},
                { "00A", "03A", "03A", "00A", "03A", "00A", "00A", "00A", "03A", "03A"},
                { "09D", "03A", "00A", "00A", "01A", "00A", "00A", "00A", "00A", "09C"}};

            floor.geometry = geometry;

            // Enemies
            string[,] enemies = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.enemies = enemies;

            // Items
            string[,] items = new string[FloorData.FLOOR_COLS, FloorData.FLOOR_ROWS] {
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"},
                { "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A", "00A"}};

            floor.items = items;

            // Turns Max
            floor.turnsMax = 50;

            // Skybox
            floor.skyboxId = 2;

            // BGM
            floor.bgmId = 2;

            return floor;
        }
    }
}