<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:output method="html"/>

    <xsl:template match="group">
        <h2>
            <xsl:value-of select="@group_name"/>
        </h2>
        <table cellpadding="10" border="1" cellspacing="0" bordercolor="#5d6b99">
            <tr bgcolor="#5d6b99">
                <td>
                    <b>
                        <font color="#ffffff" face="arial">День</font>
                    </b>
                </td>
                <td>
                    <b>
                        <font color="#ffffff" face="arial">Пара</font>
                    </b>
                </td>
                <td>
                    <b>
                        <font color="#ffffff" face="arial">Предмет</font>
                    </b>
                </td>
                <td>
                    <b>
                        <font color="#ffffff" face="arial">Формат</font>
                    </b>
                </td>
                <td>
                    <b>
                        <font color="#ffffff" face="arial">Тиждень</font>
                    </b>
                </td>
                <td>
                    <b>
                        <font color="#ffffff" face="arial">Підгрупа</font>
                    </b>
                </td>
                <td>
                    <b>
                        <font color="#ffffff" face="arial">Викладачі</font>
                    </b>
                </td>
            </tr>
            <xsl:for-each select="day">
                <xsl:for-each select="pair">
                    <xsl:variable name="pos" select="count(preceding-sibling::node()) mod 4"/>
                    <xsl:for-each select="lesson">
                        <xsl:if test="$pos=1">
                            <tr bgcolor="#dddddd">
                                <xsl:if test="count(preceding-sibling::node())=1">
                                    <xsl:if test="count(../preceding-sibling::node())=1">
                                        <td rowspan="{count(../../*/lesson)}" bgcolor="#afeeee">
                                            <xsl:value-of select="../../@day_index"/>
                                        </td>
                                    </xsl:if>
                                    <td rowspan="{count(../lesson)}">
                                        <xsl:value-of select="../@pair_index"/>
                                    </td>
                                </xsl:if>
                                <td>
                                    <xsl:value-of select="@subject"/>
                                </td>
                                <td>
                                    <xsl:value-of select="@format"/>
                                </td>
                                <td>
                                    <xsl:if test="not(@week='Обидва')">
                                        <xsl:value-of select="@week"/>
                                    </xsl:if>
                                </td>
                                <td>
                                    <xsl:if test="not(@subgroup='-')">
                                        <xsl:value-of select="@subgroup"/>
                                    </xsl:if>
                                </td>
                                <td>
                                    <xsl:for-each select="teacher">
                                        <xsl:value-of select="@teacher_name"/>
                                        <br/>
                                    </xsl:for-each>
                                </td>
                            </tr>
                        </xsl:if>
                        <xsl:if test="$pos=3">
                            <tr bgcolor="#f8f8f8">
                                <xsl:if test="count(preceding-sibling::node())=1">
                                    <xsl:if test="count(../preceding-sibling::node())=1">
                                        <td rowspan="{count(../../*/lesson)}">
                                            <xsl:value-of select="../../@day_index"/>
                                        </td>
                                    </xsl:if>
                                    <td rowspan="{count(../lesson)}">
                                        <xsl:value-of select="../@pair_index"/>
                                    </td>
                                </xsl:if>
                                <td>
                                    <xsl:value-of select="@subject"/>
                                </td>
                                <td>
                                    <xsl:value-of select="@format"/>
                                </td>
                                <td>
                                    <xsl:if test="not(@week='Обидва')">
                                        <xsl:value-of select="@week"/>
                                    </xsl:if>
                                </td>
                                <td>
                                    <xsl:if test="not(@subgroup='-')">
                                        <xsl:value-of select="@subgroup"/>
                                    </xsl:if>
                                </td>
                                <td>
                                    <xsl:for-each select="teacher">
                                        <xsl:value-of select="@teacher_name"/>
                                        <br/>
                                    </xsl:for-each>
                                </td>
                            </tr>
                        </xsl:if>
                    </xsl:for-each>
                </xsl:for-each>
                <tr bgcolor="#5d6b99">
                    <td colspan="7"></td>
                </tr>
            </xsl:for-each>
        </table>
    </xsl:template>
</xsl:stylesheet>