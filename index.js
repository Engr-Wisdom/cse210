class Reference {
  constructor(book, chapter, verse, endVerse = null) {
    this.book = book;
    this.chapter = chapter;
    this.verse = verse;
    this.endVerse = endVerse;
  }

  toString() {
    if (this.endVerse) {
      return `${this.book} ${this.chapter}:${this.verse}-${this.endVerse}`;
    } else {
      return `${this.book} ${this.chapter}:${this.verse}`;
    }
  }
}

class Word {
  constructor(word) {
    this.word = word;
    this.hidden = false;
  }

  hideWord() {
    this.hidden = true;
  }

  displayWord() {
    return this.hidden ? "_".repeat(this.word.length) : this.word;
  }
}

class Scripture {
  constructor(reference, scriptureText) {
    this.reference = reference;
    const words = scriptureText.split(" ");
    this.words = words.map((word) => new Word(word));
  }

  hideRandomWords(count = 3) {
    const visibleWords = this.words.filter((w) => !w.hidden);
    if (visibleWords.length === 0) return;

    for (let i = 0; i < count; i++) {
      const candidates = this.words.filter((w) => !w.hidden);
      if (candidates.length === 0) break;
      const index = Math.floor(Math.random() * candidates.length);
      candidates[index].hideWord();
    }
  }

  displayCurrentScripture() {
    const text = this.words.map((w) => w.displayWord()).join(" ");
    return `${this.reference.toString()}\n\n${text}`;
  }

  allHiddenWords() {
    return this.words.every((w) => w.hidden);
  }
}

function runScriptureMemorizer() {
  const reference = new Reference("Proverbs", 3, 5, 6);
  const scriptureText =
    "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
  const scripture = new Scripture(reference, scriptureText);

  function nextStep() {
    console.clear();
    console.log(scripture.displayCurrentScripture());

    if (scripture.allHiddenWords()) {
      console.log("\nAll words are hidden. Program complete!");
      return;
    }

    const input = prompt(
      "Press Enter to hide more words, or type 'quit' to exit:"
    );
    if (input === null || input.toLowerCase() === "quit") {
      console.log("Program ended by user.");
      return;
    } else {
      scripture.hideRandomWords();
      nextStep();
    }
  }

  nextStep();
}

runScriptureMemorizer();
