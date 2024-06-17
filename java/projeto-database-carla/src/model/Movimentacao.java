
package model;

public class Movimentacao {
    private int idMovimento;
    private String mov_data;
    private int id_produto;
    private String mov_historico;
    private int mov_quantidade;
    private double mov_valorunitario;

    /**
     * @return the idMovimento
     */
    public int getIdMovimento() {
        return idMovimento;
    }

    /**
     * @param idMovimento the idMovimento to set
     */
    public void setIdMovimento(int idMovimento) {
        this.idMovimento = idMovimento;
    }

    /**
     * @return the mov_data
     */
    public String getMov_data() {
        return mov_data;
    }

    /**
     * @param mov_data the mov_data to set
     */
    public void setMov_data(String mov_data) {
        this.mov_data = mov_data;
    }

    /**
     * @return the id_produto
     */
    public int getId_produto() {
        return id_produto;
    }

    /**
     * @param id_produto the id_produto to set
     */
    public void setId_produto(int id_produto) {
        this.id_produto = id_produto;
    }

    /**
     * @return the mov_historico
     */
    public String getMov_historico() {
        return mov_historico;
    }

    /**
     * @param mov_historico the mov_historico to set
     */
    public void setMov_historico(String mov_historico) {
        this.mov_historico = mov_historico;
    }

    /**
     * @return the mov_quantidade
     */
    public int getMov_quantidade() {
        return mov_quantidade;
    }

    /**
     * @param mov_quantidade the mov_quantidade to set
     */
    public void setMov_quantidade(int mov_quantidade) {
        this.mov_quantidade = mov_quantidade;
    }

    /**
     * @return the mov_valorunitario
     */
    public double getMov_valorunitario() {
        return mov_valorunitario;
    }

    /**
     * @param mov_valorunitario the mov_valorunitario to set
     */
    public void setMov_valorunitario(double mov_valorunitario) {
        this.mov_valorunitario = mov_valorunitario;
    }
}
