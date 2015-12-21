FROM microsoft/aspnet:1.0.0-rc1-update1-coreclr
ADD . /app
WORKDIR /app
RUN dnu restore
RUN dnx --version
ENTRYPOINT dnx run
