var arr = [1, -5, -4, -3, -2, -1, 4, 6];
var n = arr.length;
var max_ending_here = arr[0];
var max_so_far = arr[0];
var i = 0;
console.log("Iteration : " + i + ", max_ending_here : " + max_ending_here + ", max_so_far : " + max_so_far);
for (i = 1; i < n; i++) {
  max_ending_here = Math.max(max_ending_here + arr[i], arr[i]);
  max_so_far = Math.max(max_so_far, max_ending_here);
  console.log("Iteration : " + i + ", max_ending_here : " + max_ending_here + ", max_so_far : " + max_so_far);
}
console.log("final result : " + max_so_far);


/*

Output

Iteration : 0, max_ending_here : 1, max_so_far : 1
Iteration : 1, max_ending_here : -4, max_so_far : 1
Iteration : 2, max_ending_here : -4, max_so_far : 1
Iteration : 3, max_ending_here : -3, max_so_far : 1
Iteration : 4, max_ending_here : -2, max_so_far : 1
Iteration : 5, max_ending_here : -1, max_so_far : 1
Iteration : 6, max_ending_here : 4, max_so_far : 4
Iteration : 7, max_ending_here : 10, max_so_far : 10
final result : 10

*/
