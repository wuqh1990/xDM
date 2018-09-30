namespace xDM
{

   public partial interface IDM
    {
        string Ver();

        int SetPath(string path);

        string Ocr(int x1, int y1, int x2, int y2, string color, double sim);

        int FindStr(int x1, int y1, int x2, int y2, string str, string color, double sim, out int x, out int y);

        int GetResultCount(string str);

        int GetResultPos(string str, int index, out int x, out int y);

        int StrStr(string s, string str);

        int SendCommand(string cmd);

        int UseDict(int index);

        string GetBasePath();

        int SetDictPwd(string pwd);

        string OcrInFile(int x1, int y1, int x2, int y2, string pic_name, string color, double sim);

        int Capture(int x1, int y1, int x2, int y2, string file_name);

        int KeyPress(int vk);

        int KeyDown(int vk);

        int KeyUp(int vk);

        int LeftClick();

        int RightClick();

        int MiddleClick();

        int LeftDoubleClick();

        int LeftDown();

        int LeftUp();

        int RightDown();

        int RightUp();

        int MoveTo(int x, int y);

        int MoveR(int rx, int ry);

        string GetColor(int x, int y);

        string GetColorBGR(int x, int y);

        string RGB2BGR(string rgb_color);

        string BGR2RGB(string bgr_color);

        int UnBindWindow();

        int CmpColor(int x, int y, string color, double sim);

        int ShowScrMsg(int x1, int y1, int x2, int y2, string msg, string color);

        int SetMinRowGap(int row_gap);

        int SetMinColGap(int col_gap);

        int FindColor(int x1, int y1, int x2, int y2, string color, double sim, int dir, out int x, out int y);

        string FindColorEx(int x1, int y1, int x2, int y2, string color, double sim, int dir);

        int SetWordLineHeight(int line_height);

        int SetWordGap(int word_gap);

        int SetRowGapNoDict(int row_gap);

        int SetColGapNoDict(int col_gap);

        int SetWordLineHeightNoDict(int line_height);

        int SetWordGapNoDict(int word_gap);

        int GetWordResultCount(string str);

        int GetWordResultPos(string str, int index, out int x, out int y);

        string GetWordResultStr(string str, int index);

        string GetWords(int x1, int y1, int x2, int y2, string color, double sim);

        string GetWordsNoDict(int x1, int y1, int x2, int y2, string color);

        int SetShowErrorMsg(int show);

        int GetClientSize(int hwnd, out int width, out int height);

        int MoveWindow(int hwnd, int x, int y);

        string GetColorHSV(int x, int y);

        string GetAveRGB(int x1, int y1, int x2, int y2);

        string GetAveHSV(int x1, int y1, int x2, int y2);

        int GetForegroundWindow();

        int GetForegroundFocus();

        int GetMousePointWindow();

        int GetPointWindow(int x, int y);

        string EnumWindow(int parent, string title, string class_name, int filter);

        int GetWindowState(int hwnd, int flag);

        int GetWindow(int hwnd, int flag);

        int GetSpecialWindow(int flag);

        int SetWindowText(int hwnd, string text);

        int SetWindowSize(int hwnd, int width, int height);

        int GetWindowRect(int hwnd, out int x1, out int y1, out int x2, out int y2);

        string GetWindowTitle(int hwnd);

        string GetWindowClass(int hwnd);

        int SetWindowState(int hwnd, int flag);

        int CreateFoobarRect(int hwnd, int x, int y, int w, int h);

        int CreateFoobarRoundRect(int hwnd, int x, int y, int w, int h, int rw, int rh);

        int CreateFoobarEllipse(int hwnd, int x, int y, int w, int h);

        int CreateFoobarCustom(int hwnd, int x, int y, string pic, string trans_color, double sim);

        int FoobarFillRect(int hwnd, int x1, int y1, int x2, int y2, string color);

        int FoobarDrawText(int hwnd, int x, int y, int w, int h, string text, string color, int align);

        int FoobarDrawPic(int hwnd, int x, int y, string pic, string trans_color);

        int FoobarUpdate(int hwnd);

        int FoobarLock(int hwnd);

        int FoobarUnlock(int hwnd);

        int FoobarSetFont(int hwnd, string font_name, int size, int flag);

        int FoobarTextRect(int hwnd, int x, int y, int w, int h);

        int FoobarPrintText(int hwnd, string text, string color);

        int FoobarClearText(int hwnd);

        int FoobarTextLineGap(int hwnd, int gap);

        int Play(string file_name);

        int FaqCapture(int x1, int y1, int x2, int y2, int quality, int delay, int time);

        int FaqRelease(int handle);

        string FaqSend(string server, int handle, int request_type, int time_out);

        int Beep(int fre, int delay);

        int FoobarClose(int hwnd);

        int MoveDD(int dx, int dy);

        int FaqGetSize(int handle);

        int LoadPic(string pic_name);

        int FreePic(string pic_name);

        int GetScreenData(int x1, int y1, int x2, int y2);

        int FreeScreenData(int handle);

        int WheelUp();

        int WheelDown();

        int SetMouseDelay(string tpe, int delay);

        int SetKeypadDelay(string tpe, int delay);

        string GetEnv(int index, string name);

        int SetEnv(int index, string name, string value);

        int SendString(int hwnd, string str);

        int DelEnv(int index, string name);

        string GetPath();

        int SetDict(int index, string dict_name);

        int FindPic(int x1, int y1, int x2, int y2, string pic_name, string delta_color, double sim, int dir, out int x, out int y);

        string FindPicEx(int x1, int y1, int x2, int y2, string pic_name, string delta_color, double sim, int dir);

        int SetClientSize(int hwnd, int width, int height);

        long ReadInt(int hwnd, string addr, int tpe);

        float ReadFloat(int hwnd, string addr);

        double ReadDouble(int hwnd, string addr);

        string FindInt(int hwnd, string addr_range, long int_value_min, long int_value_max, int tpe);

        string FindFloat(int hwnd, string addr_range, float float_value_min, float float_value_max);

        string FindDouble(int hwnd, string addr_range, double double_value_min, double double_value_max);

        string FindString(int hwnd, string addr_range, string string_value, int tpe);

        long GetModuleBaseAddr(int hwnd, string module_name);

        string MoveToEx(int x, int y, int w, int h);

        string MatchPicName(string pic_name);

        int AddDict(int index, string dict_info);

        int EnterCri();

        int LeaveCri();

        int WriteInt(int hwnd, string addr, int tpe, long v);

        int WriteFloat(int hwnd, string addr, float v);

        int WriteDouble(int hwnd, string addr, double v);

        int WriteString(int hwnd, string addr, int tpe, string v);

        int AsmAdd(string asm_ins);

        int AsmClear();

        long AsmCall(int hwnd, int mode);

        int FindMultiColor(int x1, int y1, int x2, int y2, string first_color, string offset_color, double sim, int dir, out int x, out int y);

        string FindMultiColorEx(int x1, int y1, int x2, int y2, string first_color, string offset_color, double sim, int dir);

        string Assemble(long base_addr, int is_64bit);

        string DisAssemble(string asm_code, long base_addr, int is_64bit);

        int SetWindowTransparent(int hwnd, int v);

        string ReadData(int hwnd, string addr, int length);

        int WriteData(int hwnd, string addr, string data);

        string FindData(int hwnd, string addr_range, string data);

        int SetPicPwd(string pwd);

        int Log(string info);

        string FindStrE(int x1, int y1, int x2, int y2, string str, string color, double sim);

        string FindColorE(int x1, int y1, int x2, int y2, string color, double sim, int dir);

        string FindPicE(int x1, int y1, int x2, int y2, string pic_name, string delta_color, double sim, int dir);

        string FindMultiColorE(int x1, int y1, int x2, int y2, string first_color, string offset_color, double sim, int dir);

        int SetExactOcr(int exact_ocr);

        string ReadString(int hwnd, string addr, int tpe, int length);

        int FoobarTextPrintDir(int hwnd, int dir);

        string OcrEx(int x1, int y1, int x2, int y2, string color, double sim);

        int SetDisplayInput(string mode);

        int GetTime();

        int GetScreenWidth();

        int GetScreenHeight();

        int BindWindowEx(int hwnd, string display, string mouse, string keypad, string _desc, int mode);

        string GetDiskSerial();

        string Md5(string str);

        string GetMac();

        int ActiveInputMethod(int hwnd, string id);

        int CheckInputMethod(int hwnd, string id);

        int FindInputMethod(string id);

        int GetCursorPos(out int x, out int y);

        int BindWindow(int hwnd, string display, string mouse, string keypad, int mode);

        int FindWindow(string class_name, string title_name);

        int GetScreenDepth();

        int SetScreen(int width, int height, int depth);

        int ExitOs(int tpe);

        string GetDir(int tpe);

        int GetOsType();

        int FindWindowEx(int parent, string class_name, string title_name);

        int SetExportDict(int index, string dict_name);

        string GetCursorShape();

        int DownCpu(int rate);

        string GetCursorSpot();

        int SendString2(int hwnd, string str);

        int FaqPost(string server, int handle, int request_type, int time_out);

        string FaqFetch();

        string FetchWord(int x1, int y1, int x2, int y2, string color, string word);

        int CaptureJpg(int x1, int y1, int x2, int y2, string file_name, int quality);

        int FindStrWithFont(int x1, int y1, int x2, int y2, string str, string color, double sim, string font_name, int font_size, int flag, out int x, out int y);

        string FindStrWithFontE(int x1, int y1, int x2, int y2, string str, string color, double sim, string font_name, int font_size, int flag);

        string FindStrWithFontEx(int x1, int y1, int x2, int y2, string str, string color, double sim, string font_name, int font_size, int flag);

        string GetDictInfo(string str, string font_name, int font_size, int flag);

        int SaveDict(int index, string file_name);

        int GetWindowProcessId(int hwnd);

        string GetWindowProcessPath(int hwnd);

        int LockInput(int locks);

        string GetPicSize(string pic_name);

        int GetID();

        int CapturePng(int x1, int y1, int x2, int y2, string file_name);

        int CaptureGif(int x1, int y1, int x2, int y2, string file_name, int delay, int time);

        int ImageToBmp(string pic_name, string bmp_name);

        int FindStrFast(int x1, int y1, int x2, int y2, string str, string color, double sim, out int x, out int y);

        string FindStrFastEx(int x1, int y1, int x2, int y2, string str, string color, double sim);

        string FindStrFastE(int x1, int y1, int x2, int y2, string str, string color, double sim);

        int EnableDisplayDebug(int enable_debug);

        int CapturePre(string file_name);

        int RegEx(string code, string Ver, string ip);

        string GetMachineCode();

        int SetClipboard(string data);

        string GetClipboard();

        int GetNowDict();

        int Is64Bit();

        int GetColorNum(int x1, int y1, int x2, int y2, string color, double sim);

        string EnumWindowByProcess(string process_name, string title, string class_name, int filter);

        int GetDictCount(int index);

        int GetLastError();

        string GetNetTime();

        int EnableGetColorByCapture(int en);

        int CheckUAC();

        int SetUAC(int uac);

        int DisableFontSmooth();

        int CheckFontSmooth();

        int SetDisplayAcceler(int level);

        int FindWindowByProcess(string process_name, string class_name, string title_name);

        int FindWindowByProcessId(int process_id, string class_name, string title_name);

        string ReadIni(string section, string key, string file_name);

        int WriteIni(string section, string key, string v, string file_name);

        int RunApp(string path, int mode);

        int delay(int mis);

        int FindWindowSuper(string spec1, int flag1, int type1, string spec2, int flag2, int type2);

        string ExcludePos(string all_pos, int tpe, int x1, int y1, int x2, int y2);

        string FindNearestPos(string all_pos, int tpe, int x, int y);

        string SortPosDistance(string all_pos, int tpe, int x, int y);

        int FindPicMem(int x1, int y1, int x2, int y2, string pic_info, string delta_color, double sim, int dir, out int x, out int y);

        string FindPicMemEx(int x1, int y1, int x2, int y2, string pic_info, string delta_color, double sim, int dir);

        string FindPicMemE(int x1, int y1, int x2, int y2, string pic_info, string delta_color, double sim, int dir);

        string AppendPicAddr(string pic_info, int addr, int size);

        int WriteFile(string file_name, string content);

        int Stop(int id);

        int SetDictMem(int index, int addr, int size);

        string GetNetTimeSafe();

        int ForceUnBindWindow(int hwnd);

        string ReadIniPwd(string section, string key, string file_name, string pwd);

        int WriteIniPwd(string section, string key, string v, string file_name, string pwd);

        int DecodeFile(string file_name, string pwd);

        int KeyDownChar(string key_str);

        int KeyUpChar(string key_str);

        int KeyPressChar(string key_str);

        int KeyPressStr(string key_str, int delay);

        int EnableKeypadPatch(int en);

        int EnableKeypadSync(int en, int time_out);

        int EnableMouseSync(int en, int time_out);

        int DmGuard(int en, string tpe);

        int FaqCaptureFromFile(int x1, int y1, int x2, int y2, string file_name, int quality);

        string FindIntEx(int hwnd, string addr_range, long int_value_min, long int_value_max, int tpe, int steps, int multi_thread, int mode);

        string FindFloatEx(int hwnd, string addr_range, float float_value_min, float float_value_max, int steps, int multi_thread, int mode);

        string FindDoubleEx(int hwnd, string addr_range, double double_value_min, double double_value_max, int steps, int multi_thread, int mode);

        string FindStringEx(int hwnd, string addr_range, string string_value, int tpe, int steps, int multi_thread, int mode);

        string FindDataEx(int hwnd, string addr_range, string data, int steps, int multi_thread, int mode);

        int EnableRealMouse(int en, int mousedelay, int mousestep);

        int EnableRealKeypad(int en);

        int SendStringIme(string str);

        int FoobarDrawLine(int hwnd, int x1, int y1, int x2, int y2, string color, int style, int width);

        string FindStrEx(int x1, int y1, int x2, int y2, string str, string color, double sim);

        int IsBind(int hwnd);

        int SetDisplayDelay(int t);

        int GetDmCount();

        int DisableScreenSave();

        int DisablePowerSave();

        int SetMemoryHwndAsProcessId(int en);

        int FindShape(int x1, int y1, int x2, int y2, string offset_color, double sim, int dir, out int x, out int y);

        string FindShapeE(int x1, int y1, int x2, int y2, string offset_color, double sim, int dir);

        string FindShapeEx(int x1, int y1, int x2, int y2, string offset_color, double sim, int dir);

        string FindStrS(int x1, int y1, int x2, int y2, string str, string color, double sim, out int x, out int y);

        string FindStrExS(int x1, int y1, int x2, int y2, string str, string color, double sim);

        string FindStrFastS(int x1, int y1, int x2, int y2, string str, string color, double sim, out int x, out int y);

        string FindStrFastExS(int x1, int y1, int x2, int y2, string str, string color, double sim);

        string FindPicS(int x1, int y1, int x2, int y2, string pic_name, string delta_color, double sim, int dir, out int x, out int y);

        string FindPicExS(int x1, int y1, int x2, int y2, string pic_name, string delta_color, double sim, int dir);

        int ClearDict(int index);

        string GetMachineCodeNoMac();

        int GetClientRect(int hwnd, out int x1, out int y1, out int x2, out int y2);

        int EnableFakeActive(int en);

        int GetScreenDataBmp(int x1, int y1, int x2, int y2, out int data, out int size);

        int EncodeFile(string file_name, string pwd);

        string GetCursorShapeEx(int tpe);

        int FaqCancel();

        string IntToData(long int_value, int tpe);

        string FloatToData(float float_value);

        string DoubleToData(double double_value);

        string StringToData(string string_value, int tpe);

        int SetMemoryFindResultToFile(string file_name);

        int EnableBind(int en);

        int SetSimMode(int mode);

        int LockMouseRect(int x1, int y1, int x2, int y2);

        int SendPaste(int hwnd);

        int IsDisplayDead(int x1, int y1, int x2, int y2, int t);

        int GetKeyState(int vk);

        int CopyFile(string src_file, string dst_file, int over);

        int IsFileExist(string file_name);

        int DeleteFile(string file_name);

        int MoveFile(string src_file, string dst_file);

        int CreateFolder(string folder_name);

        int DeleteFolder(string folder_name);

        int GetFileLength(string file_name);

        string ReadFile(string file_name);

        int WaitKey(int key_code, int time_out);

        int DeleteIni(string section, string key, string file_name);

        int DeleteIniPwd(string section, string key, string file_name, string pwd);

        int EnableSpeedDx(int en);

        int EnableIme(int en);

        int Reg(string code, string Ver);

        string SelectFile();

        string SelectDirectory();

        int LockDisplay(int locks);

        int FoobarSetSave(int hwnd, string file_name, int en, string header);

        string EnumWindowSuper(string spec1, int flag1, int type1, string spec2, int flag2, int type2, int sort);

        int DownloadFile(string url, string save_file, int timeout);

        int EnableKeypadMsg(int en);

        int EnableMouseMsg(int en);

        int RegNoMac(string code, string Ver);

        int RegExNoMac(string code, string Ver, string ip);

        int SetEnumWindowDelay(int delay);

        int FindMulColor(int x1, int y1, int x2, int y2, string color, double sim);

        string GetDict(int index, int font_index);

        int GetBindWindow();

        int FoobarStartGif(int hwnd, int x, int y, string pic_name, int repeat_limit, int delay);

        int FoobarStopGif(int hwnd, int x, int y, string pic_name);

        int FreeProcessMemory(int hwnd);

        string ReadFileData(string file_name, int start_pos, int end_pos);

        long VirtualAllocEx(int hwnd, long addr, int size, int tpe);

        int VirtualFreeEx(int hwnd, long addr);

        string GetCommandLine(int hwnd);

        int TerminateProcess(int pid);

        string GetNetTimeByIp(string ip);

        string EnumProcess(string name);

        string GetProcessInfo(int pid);

        long ReadIntAddr(int hwnd, long addr, int tpe);

        string ReadDataAddr(int hwnd, long addr, int length);

        double ReadDoubleAddr(int hwnd, long addr);

        float ReadFloatAddr(int hwnd, long addr);

        string ReadStringAddr(int hwnd, long addr, int tpe, int length);

        int WriteDataAddr(int hwnd, long addr, string data);

        int WriteDoubleAddr(int hwnd, long addr, double v);

        int WriteFloatAddr(int hwnd, long addr, float v);

        int WriteIntAddr(int hwnd, long addr, int tpe, long v);

        int WriteStringAddr(int hwnd, long addr, int tpe, string v);

        int Delays(int min_s, int max_s);

        int FindColorBlock(int x1, int y1, int x2, int y2, string color, double sim, int count, int width, int height, out int x, out int y);

        string FindColorBlockEx(int x1, int y1, int x2, int y2, string color, double sim, int count, int width, int height);

        int OpenProcess(int pid);

        string EnumIniSection(string file_name);

        string EnumIniSectionPwd(string file_name, string pwd);

        string EnumIniKey(string section, string file_name);

        string EnumIniKeyPwd(string section, string file_name, string pwd);

        int SwitchBindWindow(int hwnd);

        int InitCri();

        int SendStringIme2(int hwnd, string str, int mode);

        string EnumWindowByProcessId(int pid, string title, string class_name, int filter);

        string GetDisplayInfo();

        int EnableFontSmooth();

        string OcrExOne(int x1, int y1, int x2, int y2, string color, double sim);

        int SetAero(int en);

        int FoobarSetTrans(int hwnd, int trans, string color, double sim);

        int EnablePicCache(int en);

        int FaqIsPosted();

        int LoadPicByte(int addr, int size, string name);

        int MiddleDown();

        int MiddleUp();

        int FaqCaptureString(string str);

        int VirtualProtectEx(int hwnd, long addr, int size, int tpe, int old_protect);

        int SetMouseSpeed(int speed);

        int GetMouseSpeed();

        int EnableMouseAccuracy(int en);

        int SetExcludeRegion(int tpe, string info);

        int EnableShareDict(int en);

        int DisableCloseDisplayAndSleep();

        int Int64ToInt32(long v);

        int GetLocale();

        int SetLocale();

        int ReadDataToBin(int hwnd, string addr, int length);

        int WriteDataFromBin(int hwnd, string addr, int data, int length);

        int ReadDataAddrToBin(int hwnd, long addr, int length);

        int WriteDataAddrFromBin(int hwnd, long addr, int data, int length);

        int SetParam64ToPointer();

        int GetDPI();

        int SetDisplayRefreshDelay(int t);

        int IsFolderExist(string folder);

        int GetCpuType();

        int ReleaseRef();

        int SetExitThread(int en);

        int GetFps();

        string VirtualQueryEx(int hwnd, long addr, int pmbi);

        long AsmCallEx(int hwnd, int mode, string base_addr);

        long GetRemoteApiAddress(int hwnd, long base_addr, string fun_name);

        string ExecuteCmd(string cmd, string current_dir, int time_out);

        int SpeedNormalGraphic(int en);

        int UnLoadDriver();

        int GetOsBuildNumber();

        int HackSpeed(double rate);

        string GetRealPath(string path);

        int ShowTaskBarIcon(int hwnd, int is_show);
    }
}