var arr = [ 
    {
        title: 'Bill Gates',
        author: 'The Road Ahead',
        read: true
    },
    {
        title: 'Steve Jobs',
        author: 'Walter Isaacson',
        read: true
    },
    {
        title: 'Mockingjay: The Final Book of The Hunger Games',
        author: 'Suzanne Collins',
        read: false
    }];

for (var i = 0; i < arr.length; i++) 
   {
    var book = "'" + arr[i].title + "'" + ' by ' + arr[i].author + ", ";
    if (arr[i].read) {
      console.log(book + "Already read ");
    } else
    {
     console.log(book + "You still need to read ");
    }
   }