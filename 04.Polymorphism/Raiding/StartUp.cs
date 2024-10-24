﻿using Raiding;
using Raiding.Factories;
using Raiding.Factories.Interfaces;
using Raiding.IO;
using Raiding.IO.Interfaces;

IReader reader = new ConsoleReader();
IWriter writer = new ConsoleWriter();
IHeroFactory heroFactory = new HeroFactory();

IEngine engine = new Engine(reader, writer, heroFactory);

engine.Run();