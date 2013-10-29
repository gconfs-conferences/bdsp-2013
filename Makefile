all:
	xelatex src.tex && xelatex src.tex && evince src.pdf

run:
	xelatex src.tex && xelatex src.tex && evince src.pdf

clean:
	rm *.aux *.pdf *.nav *.toc *.log *.out *.snm
