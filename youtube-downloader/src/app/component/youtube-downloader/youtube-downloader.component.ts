import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-youtube-downloader',
  imports: [FormsModule,CommonModule],
  templateUrl: './youtube-downloader.component.html',
  styleUrl: './youtube-downloader.component.css'
})
export class YoutubeDownloaderComponent {
selectedFormat:any;
videoUrl:string = "";
download(){
  alert("clicked on download button ")
}
}
