﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace CSgloww
{
    class Program
    {
        /*
        public static class netvars
        {
            public const Int32 cs_gamerules_data = 0x0;
            public const Int32 m_ArmorValue = 0xB340;
            public const Int32 m_Collision = 0x31C;
            public const Int32 m_CollisionGroup = 0x474;
            public const Int32 m_Local = 0x2FBC;
            public const Int32 m_MoveType = 0x25C;
            public const Int32 m_OriginalOwnerXuidHigh = 0x31B4;
            public const Int32 m_OriginalOwnerXuidLow = 0x31B0;
            public const Int32 m_SurvivalGameRuleDecisionTypes = 0x1320;
            public const Int32 m_SurvivalRules = 0xCF8;
            public const Int32 m_aimPunchAngle = 0x302C;
            public const Int32 m_aimPunchAngleVel = 0x3038;
            public const Int32 m_angEyeAnglesX = 0xB344;
            public const Int32 m_angEyeAnglesY = 0xB348;
            public const Int32 m_bBombPlanted = 0x99D;
            public const Int32 m_bFreezePeriod = 0x20;
            public const Int32 m_bGunGameImmunity = 0x392C;
            public const Int32 m_bHasDefuser = 0xB350;
            public const Int32 m_bHasHelmet = 0xB334;
            public const Int32 m_bInReload = 0x3285;
            public const Int32 m_bIsDefusing = 0x3918;
            public const Int32 m_bIsQueuedMatchmaking = 0x74;
            public const Int32 m_bIsScoped = 0x3910;
            public const Int32 m_bIsValveDS = 0x75;
            public const Int32 m_bSpotted = 0x93D;
            public const Int32 m_bSpottedByMask = 0x980;
            public const Int32 m_bStartedArming = 0x33D0;
            public const Int32 m_clrRender = 0x70;
            public const Int32 m_dwBoneMatrix = 0x26A8;
            public const Int32 m_fAccuracyPenalty = 0x3310;
            public const Int32 m_fFlags = 0x104;
            public const Int32 m_flC4Blow = 0x2990;
            public const Int32 m_flDefuseCountDown = 0x29AC;
            public const Int32 m_flDefuseLength = 0x29A8;
            public const Int32 m_flFallbackWear = 0x31C0;
            public const Int32 m_flFlashDuration = 0xA3F4;
            public const Int32 m_flFlashMaxAlpha = 0xA3F0;
            public const Int32 m_flLastBoneSetupTime = 0x2924;
            public const Int32 m_flLowerBodyYawTarget = 0x3A78;
            public const Int32 m_flNextAttack = 0x2D70;
            public const Int32 m_flNextPrimaryAttack = 0x3218;
            public const Int32 m_flSimulationTime = 0x268;
            public const Int32 m_flTimerLength = 0x2994;
            public const Int32 m_hActiveWeapon = 0x2EF8;
            public const Int32 m_hMyWeapons = 0x2DF8;
            public const Int32 m_hObserverTarget = 0x3388;
            public const Int32 m_hOwner = 0x29CC;
            public const Int32 m_hOwnerEntity = 0x14C;
            public const Int32 m_iAccountID = 0x2FC8;
            public const Int32 m_iClip1 = 0x3244;
            public const Int32 m_iCompetitiveRanking = 0x1A84;
            public const Int32 m_iCompetitiveWins = 0x1B88;
            public const Int32 m_iCrosshairId = 0xB3AC;
            public const Int32 m_iEntityQuality = 0x2FAC;
            public const Int32 m_iFOV = 0x31E4;
            public const Int32 m_iFOVStart = 0x31E8;
            public const Int32 m_iGlowIndex = 0xA40C;
            public const Int32 m_iHealth = 0x100;
            public const Int32 m_iItemDefinitionIndex = 0x2FAA;
            public const Int32 m_iItemIDHigh = 0x2FC0;
            public const Int32 m_iMostRecentModelBoneCounter = 0x2690;
            public const Int32 m_iObserverMode = 0x3374;
            public const Int32 m_iShotsFired = 0xA380;
            public const Int32 m_iState = 0x3238;
            public const Int32 m_iTeamNum = 0xF4;
            public const Int32 m_lifeState = 0x25F;
            public const Int32 m_nFallbackPaintKit = 0x31B8;
            public const Int32 m_nFallbackSeed = 0x31BC;
            public const Int32 m_nFallbackStatTrak = 0x31C4;
            public const Int32 m_nForceBone = 0x268C;
            public const Int32 m_nTickBase = 0x342C;
            public const Int32 m_rgflCoordinateFrame = 0x444;
            public const Int32 m_szCustomName = 0x303C;
            public const Int32 m_szLastPlaceName = 0x35B0;
            public const Int32 m_thirdPersonViewAngles = 0x31D8;
            public const Int32 m_vecOrigin = 0x138;
            public const Int32 m_vecVelocity = 0x114;
            public const Int32 m_vecViewOffset = 0x108;
            public const Int32 m_viewPunchAngle = 0x3020;
        }
        public static class signatures
        {
            public const Int32 clientstate_choked_commands = 0x4D28;
            public const Int32 clientstate_delta_ticks = 0x174;
            public const Int32 clientstate_last_outgoing_command = 0x4D24;
            public const Int32 clientstate_net_channel = 0x9C;
            public const Int32 convar_name_hash_table = 0x2F0F8;
            public const Int32 dwClientState = 0x58ECFC;
            public const Int32 dwClientState_GetLocalPlayer = 0x180;
            public const Int32 dwClientState_IsHLTV = 0x4D40;
            public const Int32 dwClientState_Map = 0x28C;
            public const Int32 dwClientState_MapDirectory = 0x188;
            public const Int32 dwClientState_MaxPlayer = 0x388;
            public const Int32 dwClientState_PlayerInfo = 0x52B8;
            public const Int32 dwClientState_State = 0x108;
            public const Int32 dwClientState_ViewAngles = 0x4D88;
            public const Int32 dwEntityList = 0x4D05AF4;
            public const Int32 dwForceAttack = 0x31371BC;
            public const Int32 dwForceAttack2 = 0x31371C8;
            public const Int32 dwForceBackward = 0x31371F8;
            public const Int32 dwForceForward = 0x31371D4;
            public const Int32 dwForceJump = 0x51A91AC;
            public const Int32 dwForceLeft = 0x31371EC;
            public const Int32 dwForceRight = 0x3137210;
            public const Int32 dwGameDir = 0x635170;
            public const Int32 dwGameRulesProxy = 0x521B4F4;
            public const Int32 dwGetAllClasses = 0xD1896C;
            public const Int32 dwGlobalVars = 0x58EA00;
            public const Int32 dwGlowObjectManager = 0x5245F08;
            public const Int32 dwInput = 0x5150B40;
            public const Int32 dwInterfaceLinkList = 0x8C8334;
            public const Int32 dwLocalPlayer = 0xCF3A4C;
            public const Int32 dwMouseEnable = 0xCF9598;
            public const Int32 dwMouseEnablePtr = 0xCF9568;
            public const Int32 dwPlayerResource = 0x313553C;
            public const Int32 dwRadarBase = 0x513A854;
            public const Int32 dwSensitivity = 0xCF9434;
            public const Int32 dwSensitivityPtr = 0xCF9408;
            public const Int32 dwSetClanTag = 0x897C0;
            public const Int32 dwViewMatrix = 0x4CF7524;
            public const Int32 dwWeaponTable = 0x5151604;
            public const Int32 dwWeaponTableIndex = 0x323C;
            public const Int32 dwYawPtr = 0xCF91F8;
            public const Int32 dwZoomSensitivityRatioPtr = 0xCFE418;
            public const Int32 dwbSendPackets = 0xD2B0A;
            public const Int32 dwppDirect3DDevice9 = 0xA6030;
            public const Int32 force_update_spectator_glow = 0x393362;
            public const Int32 interface_engine_cvar = 0x3E9EC;
            public const Int32 is_c4_owner = 0x39F5A0;
            public const Int32 m_bDormant = 0xED;
            public const Int32 m_pStudioHdr = 0x294C;
            public const Int32 m_pitchClassPtr = 0x513AB00;
            public const Int32 m_yawClassPtr = 0xCF91F8;
            public const Int32 model_ambient_min = 0x591D1C;
            public const Int32 set_abs_angles = 0x1CA9B0;
            public const Int32 set_abs_origin = 0x1CA7F0;
        }
        */
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;



        [DllImport("user32.dll")]
        static extern ushort GetAsyncKeyState(int vKey);

        public static bool IsKeyPushedDown(System.Windows.Forms.Keys vKey)
        {
            return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
        }



        public static int client;
        public static int engine;
        public static int enginepointer;
        public static string process = "csgo";

        static bool GetModuleAddy()
        {
            try
            {
                Process[] p = Process.GetProcessesByName(process);
                bool c = false;
                bool e = false;

               // Process targetprocess = Process.GetProcessesByName(process)[0];
               // SigScanSharp sigScan = new SigScanSharp(p[0].Handle);
                


                //long lTime;               

                if (p.Length > 0)
                {
                    foreach (ProcessModule m in p[0].Modules)
                    {
                        if (m.ModuleName == "client_panorama.dll")
                        {
                            client = (int)m.BaseAddress;
                            c = true;
                            Console.WriteLine("client panorama found.");
                        }
                        if (m.ModuleName == "engine.dll")
                        {
                            engine = (int)m.BaseAddress;
                            //sigScan.SelectModule(m);
                           // enginepointer = (int)sigScan.FindPattern("A1 ? ? ? ? 8B 88 ? ? ? ? 85 C9 74 15", out lTime);
                            e = true;
                            Console.WriteLine("engine found.");
                        }
                    }
                    return c&&e;

                }
                else
                {
                    Console.WriteLine("Press enter to close...");
                    Console.ReadLine();
                    return false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Press enter to close...");
                Console.ReadLine();
                return false;
            }
        }

        public struct GlowStruct
        {
            public float r;
            public float g;
            public float b;
            public float a;
            public bool rwo;
            public bool rwuo;
        }

        public struct Player
        {
            public int Team;
            public int Health;
            public vector Position;
            public int weaponID;
            public vector Velocity;
            public GlowStruct glow;
        }

        public struct vector
        {
            public float x, y, z;
        }

        public static bool SeenBy(int entityIndex)
        {
            return (hazedumper.netvars.m_bSpottedByMask & (0x1 << entityIndex)) != 0;
        }
        /*
        public bool SeenBy(Player ent)
        {
            return SeenBy(ent. - 1);

        }
        */

            public static void BHop()
        {
            int localPlayer = vam.ReadInt32((IntPtr)(client+oLocalPlayer));
            if (localPlayer != 0)
            {
                while(localPlayer != 0)
                {
                    if (checkBoxBHop)
                    {
                        int flag = vam.ReadInt32((IntPtr)(localPlayer + hazedumper.netvars.m_fFlags));
                       // int z = (int)vam.ReadFloat((IntPtr)(localPlayer + netvars.m_vecVelocity + 0x8));

                        if (IsKeyPushedDown(Keys.Space) && (flag == 257||flag == 263))
                        {
                            vam.WriteInt32((IntPtr)(client + hazedumper.signatures.dwForceJump), 6);
                        }
                    }
                    
                    
                }
            }
        }





        public static void shoot(float tbDelay)
        {
            Thread.Sleep((int)tbDelay);
            vam.WriteInt32((IntPtr)(client + iAttack), 5);
            Thread.Sleep(10);
            vam.WriteInt32((IntPtr)(client + iAttack), 4);

        }

        public static bool checkifshoot(Player player, Player MyPlayer)
        {

            if ((MyPlayer.Team != player.Team) && (player.Health > 0))
            {
                return true;
            }

                return false;
        }

        public static bool isScoped(int weaponID)
        {
            if ((weaponID == 40)||(weaponID == 9))
            {
                int localPlayer = vam.ReadInt32((IntPtr)(client + oLocalPlayer));
                Player player = new Player();
                player = GetMyPlayerInfo(localPlayer);
                bool isMoving=false;
                //Console.WriteLine(player.Velocity.z);
                if (0 != (int)(player.Velocity.x + player.Velocity.y + player.Velocity.z))
                {
                    isMoving = true;
                }
                

                return (vam.ReadBoolean((IntPtr)(localPlayer + hazedumper.netvars.m_bIsScoped))) && !isMoving;
            }
            return true;
        }

        public static float setTBDelay(int weaponID, float distance)
        {
           float delay = 0;
            switch (weaponID)
            {
                case 16:delay = 3; break;
                case 7: delay = 3.3f; break;
                case 40: delay = 0; break;
                case 9: delay = 0; break;
                case 42: delay = 0; break;
                case 1: delay = 4.2f; break;
                default: delay = 3.3f; break;
            }
            return (delay * distance);
        }

        public static void handleTB(Player MyPlayer, Player player)
        {
            if (checkifshoot(player, MyPlayer))
            {
                int weaponID = getMyWeapon();
                float Delay = setTBDelay(weaponID, Distance(MyPlayer.Position, player.Position));
                if (isScoped(weaponID))
                {
                    if (weaponID == 42 || weaponID == 59) //нож не доделан
                    {
                        if (Distance(MyPlayer.Position, player.Position)<32)
                        {
                           // vam.WriteInt32((IntPtr)(client + signatures.dwForceAttack2), 2);
                           // Thread.Sleep(10);
                           // vam.WriteInt32((IntPtr)(client + signatures.dwForceAttack2), 1);
                        }
                    }
                    else
                    {
                        shoot(Delay);
                    }

                }
                    
            }
                

        }



      
        const int oLocalPlayer = hazedumper.signatures.dwLocalPlayer;
        const int oTeam = hazedumper.netvars.m_iTeamNum;
        const int oEntityList = hazedumper.signatures.dwEntityList;
        const int oDormant = hazedumper.signatures.m_bDormant;
        const int oGlowIndex = hazedumper.netvars.m_iGlowIndex;
        const int oGlowObject = hazedumper.signatures.dwGlowObjectManager;
        const int oCrosshairID = hazedumper.netvars.m_iCrosshairId;
        const int iHealth = hazedumper.netvars.m_iHealth;
        const int iAttack = hazedumper.signatures.dwForceAttack;
        const int vecOrigin = hazedumper.netvars.m_vecOrigin;

        public static int getMyWeapon()
        {
            int weaponID=0;
            int localPlayer = vam.ReadInt32((IntPtr)(client+oLocalPlayer));
            int weapon = vam.ReadInt32((IntPtr)(localPlayer + hazedumper.netvars.m_hActiveWeapon));
            int weaponEntity = vam.ReadInt32((IntPtr)(client + oEntityList + ((weapon & 0xFFF) - 1) * 0x10));
            if (weaponEntity != 0)
            {
                weaponID = vam.ReadInt32((IntPtr)(weaponEntity + hazedumper.netvars.m_iItemDefinitionIndex));
            }
            //Console.WriteLine(weaponID);
            return weaponID;
        }


        public static float Distance (vector first, vector second)
        {
            float dis;
            dis = (float)(Math.Sqrt(Math.Pow(first.x - second.x, 2)+ Math.Pow(first.y - second.y, 2)+ Math.Pow(first.z - second.z, 2))*0.0254);
            return dis;
        }


        public static Player GetMyPlayerInfo(int entity)
        {
            Player player = new Player();
            player.Team = vam.ReadInt32((IntPtr)(entity + oTeam));
            player.Health = vam.ReadInt32((IntPtr)(entity + iHealth));

            player.Position.x = vam.ReadFloat((IntPtr)(entity + vecOrigin));
            player.Position.y = vam.ReadFloat((IntPtr)(entity + vecOrigin + 0x4));
            player.Position.z = vam.ReadFloat((IntPtr)(entity + vecOrigin + 0x8));

            player.Velocity.x = vam.ReadFloat((IntPtr)(entity + hazedumper.netvars.m_vecVelocity));
            player.Velocity.y = vam.ReadFloat((IntPtr)(entity + hazedumper.netvars.m_vecVelocity + 0x4));
            player.Velocity.z = vam.ReadFloat((IntPtr)(entity + hazedumper.netvars.m_vecVelocity + 0x8));
            return player;
        }

        
        public static Player GetPlayerInfo(int entity, int i)
        {
            Player player = new Player();
            entity = vam.ReadInt32((IntPtr)(entity + (i - 1) * 0x10));
            player.Team = vam.ReadInt32((IntPtr)(entity + oTeam));
            player.Health = vam.ReadInt32((IntPtr)(entity + iHealth));
            player.Position.x = vam.ReadFloat((IntPtr)(entity + vecOrigin));
            player.Position.y = vam.ReadFloat((IntPtr)(entity + vecOrigin + 0x4));
            player.Position.z = vam.ReadFloat((IntPtr)(entity + vecOrigin + 0x8));
            return player;

        }
        public static VAMemory vam = new VAMemory(process);

        public static void TriggrerbotThread()
        {
            while (true)
            {
                Player MyPlayer = new Player();
                Player player = new Player();
                int address;
                address = client + oLocalPlayer;
                int lPlayer = vam.ReadInt32((IntPtr)address);
                if (checkBoxTrigger)  //triggerbot
                {
                    address = lPlayer + oCrosshairID;
                    int crosshair = vam.ReadInt32((IntPtr)address);
                    if ((crosshair > 0) && (crosshair < 30))
                    {


                        address = client + oEntityList + ((crosshair - 1) * 0x10);
                        int entity = vam.ReadInt32((IntPtr)address);
                        //Console.WriteLine(crosshair);

                        MyPlayer = GetMyPlayerInfo(lPlayer);
                        player = GetMyPlayerInfo(entity);

                        handleTB(MyPlayer, player);
                    }
                }
                Thread.Sleep(1);
            }
        }

        public static bool checkBoxGlow=true;
        public static bool checkBoxTrigger = true;
        public static bool checkBoxBHop = true;
        public static bool checkBoxOnlyEnemy = false;
        public static bool checkBoxSpotted = false;

        public static void MenuThread()
        {
            Menu menu = new Menu();
            System.Windows.Forms.Application.Run(menu);
            menu.Show();                     
        }

        public static GlowStruct enemy = new GlowStruct();
        public static GlowStruct ally = new GlowStruct();


        static void Main(string[] args)
        {
            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            // Show
            //ShowWindow(handle, SW_SHOW);

            GlowStruct Enemy =  new GlowStruct()
            {
                r = 1,
                g = 0,
                b = 0,
                a = 0.8f,
                rwo = true,
                rwuo = false
            };
            GlowStruct Team = new GlowStruct()
            {
                r = 0,
                g = 0,
                b = 1,
                a = 0.6f,
                rwo = true,
                rwuo = false
            };
            Player MyPlayer = new Player();
            Player player = new Player();

            Thread mythread = new Thread(TriggrerbotThread);
            Thread BHopThread = new Thread(BHop);
            Thread menuThread = new Thread(MenuThread);
            menuThread.Start();

            if (GetModuleAddy())
            {

                int address;
                address = client + oLocalPlayer;
                int lPlayer = vam.ReadInt32((IntPtr)address);

              //  address = client + hazedumper.signatures.force_update_spectator_glow; //0xEB
              //  vam.WriteByte((IntPtr)address, 0xEB);
                BHopThread.Start();
                mythread.Start();
                
                while (true)
                {
                                                         
                    //address = client + hazedumper.signatures.force_update_spectator_glow; //0xEB
                   // vam.WriteByte((IntPtr)address, 0xEB);
                    
                    address = client + oGlowObject;
                    int GlowObject = vam.ReadInt32((IntPtr)address);                   

                    address += 0xC;
                    int objectCount = vam.ReadInt32((IntPtr)address);

                    int i = 1;
                    do
                    {

                        

                        address = client + oEntityList + (i - 1) * 0x10;
                        int EntityList = vam.ReadInt32((IntPtr)address);

                        //Console.WriteLine(EntityList);
                        if (EntityList != 0 && checkBoxGlow)
                        {


                            player = GetMyPlayerInfo(EntityList);
                            MyPlayer = GetMyPlayerInfo(lPlayer);

                            if (MyPlayer.Team != player.Team && checkBoxSpotted)
                            {
                                vam.WriteBoolean((IntPtr)(EntityList + hazedumper.netvars.m_bSpotted), true);
                            }

                            address = EntityList + oDormant;
                            if (!vam.ReadBoolean((IntPtr)address))
                            {
                                address = EntityList + oGlowIndex;

                                int GlowIndex = vam.ReadInt32((IntPtr)address);

                                if (MyPlayer.Team == player.Team)
                                {
                                    if (!checkBoxOnlyEnemy)
                                    {
                                        int calculation = GlowIndex * 0x38 + 0x4;
                                        int current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, Team.r);

                                        calculation = GlowIndex * 0x38 + 0x8;
                                        current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, Team.g);

                                        calculation = GlowIndex * 0x38 + 0xC;
                                        current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, Team.b);

                                        calculation = GlowIndex * 0x38 + 0x10;
                                        current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, ally.a);

                                        calculation = GlowIndex * 0x38 + 0x24;
                                        current = GlowObject + calculation;
                                        vam.WriteBoolean((IntPtr)current, Team.rwo);

                                        calculation = GlowIndex * 0x38 + 0x25;
                                        current = GlowObject + calculation;
                                        vam.WriteBoolean((IntPtr)current, Team.rwuo);
                                    }



                                }
                                else
                                {                                                                       
                                        
                                                                       
                                        int calculation = GlowIndex * 0x38 + 0x4;
                                        int current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, Enemy.r);

                                        calculation = GlowIndex * 0x38 + 0x8;
                                        current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, Enemy.g);

                                        calculation = GlowIndex * 0x38 + 0xC;
                                        current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, Enemy.b);

                                        calculation = GlowIndex * 0x38 + 0x10;
                                        current = GlowObject + calculation;
                                        vam.WriteFloat((IntPtr)current, enemy.a);

                                        calculation = GlowIndex * 0x38 + 0x24;
                                        current = GlowObject + calculation;
                                        vam.WriteBoolean((IntPtr)current, Enemy.rwo);

                                        calculation = GlowIndex * 0x38 + 0x25;
                                        current = GlowObject + calculation;
                                        vam.WriteBoolean((IntPtr)current, Enemy.rwuo);                                                                      
                                }
                            }
                        }
                        i++;
                        //address = client + hazedumper.signatures.force_update_spectator_glow; //0xEB
                        //vam.WriteByte((IntPtr)address, 0xEB);
                    }
                    while (i < objectCount);

                    Thread.Sleep(1);

                   // address =  client + netvars.
                  //  int localbase = vam.ReadInt32((IntPtr)address);
                }
            }
            Console.WriteLine("Press enter to close...");
            Console.ReadLine();
        }
    }
}
