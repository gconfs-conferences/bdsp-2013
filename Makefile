all:
	xelatex --shell-escape src.tex

run:
	evince src.pdf

clean:
	rm *.aux *.pdf *.nav *.toc *.log *.out *.snm *.vrb
