db = db.getSiblingDB("bus");
db.getCollection("passengers").find({});
db.passengers.find().sort({age:-1}).skip(5).limit(6)
db.passengers.find().sort({age:-1}).skip(3).limit(6)
