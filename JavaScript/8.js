function arr_similar(arr1, arr2) {

    for(var i = 0; i < arr1.length; i++) {
      for(var j = i; j < arr1.length; j++) {
        var result = true,
          temp = arr1[i];
        arr1[i] = arr1[j];
        arr1[j] = temp;
        for(var k = 0; k < arr1.length; k++) {
          if(arr1[k] !== arr2[k]) {
            result = false;
            break;
          }
        }
        if(result) {
          return true;
        }
        arr1[j] = arr1[i];
        arr1[i] = temp;
      }
    }
    return false;
  }
  
  console.log(arr_similar([5,6,7], [7,6,5]))