import yt_dlp

def baixar_video_youtube(url):
    opcoes = {
        'outtmpl': './%(title)s.%(ext)s',
        'format': 'bestvideo+bestaudio/best',
        'merge_output_format': 'mp4',
        'ffmpeg_location': 'C:\\ffmpeg-7.1.1\\bin',
        'postprocessor_args': [
            '-c:v', 'copy',       
            '-c:a', 'aac',        
            '-b:a', '192k'        
        ],
        'verbose': True
    }

    with yt_dlp.YoutubeDL(opcoes) as ydl:
        ydl.download([url])

if __name__ == "__main__":
    url = input("Insira o link do vídeo do YouTube: ").strip()
    if url:
        baixar_video_youtube(url)
