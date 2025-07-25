class Video{
    constructor(title, author, length) {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = [];
    }

    addComment(comment) {
        return this.comments.push(comment)
    }

    getCommentCount() {
        return this.comments.length
    }

    displayInfo() {
        console.log(`Title: ${this.title}`);
        console.log(`Author: ${this.author}`);
        console.log(`Length: ${this.length}`);
        console.log(`Number of Comments: ${this.comments.length}`);
        console.log("Comments");
        this.comments.forEach(comment => {
            console.log(`- ${comment.name}: ${comment.comment}`)
        });
        console.log()
    }
}

class Comment{
    constructor(name, comment) {
        this.name = name;
        this.comment = comment;
    }
}

const video1 = new Video("How to Bake Bread", "chef John", 3000);
video1.addComment(new Comment("Mary", "Great tutorial!"));
video1.addComment(new Comment("Bright", "I tried it and it worked"));
video1.addComment(new Comment("James", "Can I use almond flour"))

const video2 = new Video("Learn C# in 10 Minutes", "DevWizard", 11000);
video2.addComment(new Comment("Alice", "Super helful"));
video2.addComment(new Comment("Ben", "More video please"));
video2.addComment(new Comment("David!", "Thanks"));
video2.addComment(new Comment("Carla", "I love the explanation"))

const video3 = new Video("Software Engineer Road map", "Wisdom Effiong", 5000);
video3.addComment(new Comment("Elisha", "Thank you for the road map"));
video3.addComment(new Comment("Destiny", "Please create a video for cyberseurity roadmap"));
video3.addComment(new Comment("Victor", "I am so clarified with your video"))

const videos = [video1, video2, video3]

for (let video of videos) {
    video.displayInfo()
}