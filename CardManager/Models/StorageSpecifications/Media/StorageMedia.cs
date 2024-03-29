﻿using CardManager.SerializationDtos.StorageSpecifications.Media;

namespace CardManager.Models.StorageSpecifications.Media;

public interface IStorageMedia
{
    StorageMediaType Type { get; }

    string ToString();
}

public abstract class StorageMedia<TDto> : IStorageMedia
    where TDto : IStorageMediaDto
{
    public static IStorageMedia Default => new NoStorageMedia();
    
    public abstract StorageMediaType Type { get; }

    public string Description { get; set; } = string.Empty;

    public abstract TDto ToDto();

    public override string ToString() => $"{this.Type}{Environment.NewLine}{this.Description}";
}

public class NoStorageMedia : StorageMedia<NoStorageMediaDto>
{
    public override StorageMediaType Type { get; } = StorageMediaType.None;

    public override NoStorageMediaDto ToDto() => new();
}
