using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klir.TechChallenge.Infra.IoC
{
    public static class EntityExtensions
    {
        public static TDto ToDto<TEntity, TDto>(this TEntity entity) where TDto : new()
        {
            var dto = new TDto();
            var entityProperties = typeof(TEntity).GetProperties();
            var dtoProperties = typeof(TDto).GetProperties();

            foreach (var entityProperty in entityProperties)
            {
                var dtoProperty = dtoProperties.FirstOrDefault(p => p.Name == entityProperty.Name);
                if (dtoProperty != null && dtoProperty.PropertyType == entityProperty.PropertyType)
                {
                    dtoProperty.SetValue(dto, entityProperty.GetValue(entity));
                }
            }

            return dto;
        }

        public static TEntity ToEntity<TEntity, TDto>(this TDto dto) where TEntity : new()
        {
            var entity = new TEntity();
            var entityProperties = typeof(TEntity).GetProperties();
            var dtoProperties = typeof(TDto).GetProperties();

            foreach (var entityProperty in entityProperties)
            {
                var dtoProperty = dtoProperties.FirstOrDefault(p => p.Name == entityProperty.Name);
                if (dtoProperty != null && dtoProperty.PropertyType == entityProperty.PropertyType)
                {
                    entityProperty.SetValue(entity, dtoProperty.GetValue(dto));
                }
            }

            return entity;
        }
    }

}
