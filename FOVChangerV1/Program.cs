using FOVChangerV1;
using Swed32;

Renderer renderer = new Renderer();
Thread renderThread = new Thread(new ThreadStart(renderer.Start().Wait));
renderThread.Start();

Swed swed = new Swed("gamename.exe");

IntPtr baseModule = swed.GetModuleBase("gamename.exe");
int fovAddress = 0x00000; // FOV pointer address

while (true)
{
    swed.WriteFloat(baseModule, fovAddress, renderer.FOV);
    Thread.Sleep(10);
}


