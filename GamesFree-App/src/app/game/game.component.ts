import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-game',
  templateUrl: './game.component.html',
  styleUrls: ['./game.component.css']
})
export class GameComponent implements OnInit {

  games: any = [
    {
      gameid:1,
      name:"game 1",
      description : "game de ação muito legal.",
      img: 'img1.jpg'
    },
    {
      gameid:2,
      name:"game 2",
      description : "game de ação muito legal 2.",
      img: 'img1.jpg'
    },

    {
      gameid:3,
      name:"game 3",
      description : "game de ação muito legal.",
      img: 'img1.jpg'
    },
    {
      gameid:3,
      name:"game 3",
      description : "game de ação muito legal 2.",
      img: 'img1.jpg'
    },
    {
      gameid:1,
      name:"game 1",
      description : "game de ação muito legal.",
      img: 'img1.jpg'
    },
    {
      gameid:2,
      name:"game 2",
      description : "game de ação muito legal 2.",
      img: 'img1.jpg'
    },

    {
      gameid:3,
      name:"game 3",
      description : "game de ação muito legal.",
      img: 'img1.jpg'
    },
    {
      gameid:3,
      name:"game 3",
      description : "game de ação muito legal 2.",
      img: 'img1.jpg'
    },
  ];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    //this.getGames();
  }

  getGames(){
    this.http.get('http://localhost:5000/api/values').subscribe(response => { this.games = response;
      console.log(response);
    }, error =>{
      console.log(error);
    });
  }

}
