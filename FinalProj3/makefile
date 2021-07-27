JFLAGS = -g
JC = javac
.SUFFIXES: .java .class
.java.class:
		$(JC) $(JFLAGS) $*.java
		
CLASSES = \
		Answer.java \
		MCAnswer.java\
		MCSAAnswer.java\
		SAAnswer.java\
		Question.java \
		MCQuestion.java\
		MCSAQuestion.java\
		MCMAQuestion.java\
		SAQuestion.java\
		Exam.java \
		ExamTester.java
		
default: classes

classes: $(CLASSES:.java=.class)

clean:
			$(RM) *.class