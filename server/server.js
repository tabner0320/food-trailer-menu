const express = require("express");
const cors = require("cors");
const path = require("path");
const fs = require("fs");

const app = express();
const PORT = process.env.PORT || 3000;

app.use(cors());
app.use(express.json());

// ✅ Serve static files
app.use(express.static(path.join(__dirname, "public")));

// ✅ Serve the main Food Trailer page at root
app.get("/", (req, res) => {
  res.sendFile(path.join(__dirname, "public", "food-trailer.html"));
});

// Optional: API route
app.get("/api/menu", (req, res) => {
  const dataPath = path.join(__dirname, "data.json");
  try {
    const data = fs.readFileSync(dataPath, "utf8");
    res.json(JSON.parse(data));
  } catch (error) {
    res.status(500).json({ message: "Error reading menu data", error });
  }
});

app.listen(PORT, () => {
  console.log(`✅ Server running at http://localhost:${PORT}`);
});

