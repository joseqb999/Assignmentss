function arr_sum(arra) {
    var res = [0, 0];
    for(var i = 0; i < arra.length; i++) 
    {
      if(i % 2) res[1] += arra[i];
      else
        res[0] += arra[i];
    }
    return res
  }
  
  console.log(arr_sum([1, 4, 6, 7, 5, 9]))