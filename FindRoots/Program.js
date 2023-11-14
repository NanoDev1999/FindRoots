// This is the JavaScript solution

function findRoots(a, b, c) {
  const discriminant = (b ** 2) - (4 * a * c);
  const root1 = ((-b + Math.sqrt(discriminant)) / (2 * a));
  const root2 = ((-b - Math.sqrt(discriminant)) / (2 * a));
  return [root1, root2];
}

const a = 2;
const b = 10;
const c = 8;

const roots = findRoots(a, b, c);
console.log("Roots: [" + roots + "]");
