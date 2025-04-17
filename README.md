# 🖼️ ConvertImageBase64

> A fast, lightweight, and developer-friendly image-to-Base64 conversion tool built in .NET.  
> Easily convert images into Base64 strings via CLI, GUI, or automated CI/CD pipelines using Docker or GitHub Actions.

---

## 📸 Project Description

**ConvertImageBase64** is a utility application designed for developers, content creators, and automation engineers to quickly convert images (JPG, PNG, GIF, etc.) to Base64 encoded strings.

You can:
- Convert images through a desktop app (WPF)
- Use it as a backend utility in CI/CD pipelines
- Deploy and run in a containerized environment with Docker

---

## 🚀 Features

- ✅ Supports all common image formats
- ✅ Converts single or batch images to Base64
- ✅ Clean and user-friendly WPF interface
- ✅ Dockerized for easy deployment
- ✅ CI/CD support via GitHub Actions
- ✅ Lightweight and portable (.NET 8 compatible)

---

## 🛠️ Getting Started

### 🖥️ Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [Docker](https://www.docker.com/products/docker-desktop/)
- (Optional) GitHub account for GitHub Actions integration

---

## 🧱 Build the Project Locally

```bash
# Clone the repository
git clone https://github.com/potatoscript/convertimagebase64.git
cd convertimagebase64

# Restore dependencies
dotnet restore

# Build the project
dotnet build --configuration Release

# Run the application
dotnet run --project ConvertImageBase64
```

---

## 🐳 Build & Run with Docker

### 🔧 Build Docker Image

```bash
docker build -t convertimagebase64 .
```

### ▶️ Run Container

```bash
docker run --rm -v ${PWD}/images:/app/images convertimagebase64
```

> Replace `/images` with the folder containing your images. Base64 output will appear in the container logs or can be redirected.

---

## 🤖 GitHub Actions Integration

A GitHub Actions workflow (`.github/workflows/potato.yml`) is included to:

- Build the project on push
- Run tests
- Auto-deploy or push to another branch
- Trigger external services via ngrok
- Integrate with Jenkins pipelines

To enable it:
1. Add your secrets (e.g., `NGROK_AUTHTOKEN`) in your repo settings
2. Push your code to `main` or create a pull request
3. Let GitHub Actions automate the rest

See [GitHub Actions Documentation](https://docs.github.com/actions) for more details.

---

## 🔄 Example Output

```bash
Original File: logo.png
Base64 Output:
iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9h...
```

---

## 🧪 Test It

```bash
dotnet test
```

---

## 🤝 Contributing

Pull requests are welcome!  
If you’d like to suggest improvements or report bugs, please open an issue.

---

## 📜 License

MIT License © 2025 potatoscript  
See `LICENSE` file for details.

---

## 📦 DockerHub

> This project is also available on DockerHub!  
> Pull and use directly:

```bash
docker pull potatodockerhub/convertimagebase64:latest
```

---

## 🙋‍♀️ Maintainer

potatoscript  
🌐 GitHub: [@potatoscript](https://github.com/potatoscript)  
🍒 Passionate about code, coffee, and convertibles

---

