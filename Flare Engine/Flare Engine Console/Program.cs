using SDL2;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    var window = SDL.SDL_CreateWindow("TEST", 0, 0, 600, 600, SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);
    var Render = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_ACCELERATED);
    SDL.SDL_SetHint(SDL.SDL_HINT_RENDER_SCALE_QUALITY, "linear");
}
catch (Exception e)
{
    Console.WriteLine(
    SDL.SDL_GetError());
}



