﻿using CardManager.SerializationDtos.Grading.CgcGrading;

namespace CardManager.Models.Grading.CgcGrading;

public interface ICgcGrade : ICardGrade, ISerializableModel<CgcGradeDto>
{
    CgcScale Centering { get; set; }
    CgcScale Corners { get; set; }
    CgcScale Edges { get; set; }
    CgcScale Overall { get; set; }
    CgcScale Surface { get; set; }
}

public class CgcGrade : ICgcGrade
{
    public CgcScale Centering { get; set; }

    public CgcScale Corners { get; set; }

    public CgcScale Edges { get; set; }

    public CgcScale Surface { get; set; }

    public CgcScale Overall { get; set; }

    public CgcGradeDto ToDto() => new()
    {
        Centering = this.Centering,
        Corners = this.Corners,
        Edges = this.Edges,
        Overall = this.Overall,
        Surface = this.Surface,
    };
}
