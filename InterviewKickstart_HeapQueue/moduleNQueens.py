
import ClassNQueensSD

#
#
# N QUEENS 
#
#   See Problem Statement, in this project.
#
#   ----3/17/2020 thoms downes 
#
def GetSolutions_NQueens(N_RowsColumnsQueens):
    #
    #   
    #
    my_Subproblem = ClassNQueensSD(N_RowsColumnsQueens)
    my_PartialSolution = ClassNQueensSD(N_RowsColumnsQueens)



def NQueens_Helper(Subproblem, PartialSolution):
    #
    # Added 3/17/2020 thomas downes
    #

    #
    # Backtracking Case  
    #
    if (PartialSolution.AttackDetected()):
        return

    #
    # Base Case
    #


    #
    # Recursive Case 
    #
    boolAttack = False

    for iColIndex in range(Subproblem.N_GeneralProblemSize):
        #
        # Recursive Call
        #
        boolAttack = PartialSolution.AttackDetected_NextColumn(iColIndex)
        if (False == boolAttack ):
            # No Queen attacks are detected.  We can proceed
            #    with the recursive call. 
            #
            PartialSolution.setColumnChoice_isItOkay(iColIndex)
            NQueens_Helper(Subproblem, PartialSolution)





