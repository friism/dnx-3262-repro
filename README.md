This repo contains a repro for [DNX issue 3262](https://github.com/aspnet/dnx/issues/3262)


	$ docker build -t repro .
	...
	$ docker run repro
	System.IO.FileNotFoundException: Could not load file or assembly 'System.Net.NetworkInformation, Version=4.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies. The system cannot find the file specified.
	...
