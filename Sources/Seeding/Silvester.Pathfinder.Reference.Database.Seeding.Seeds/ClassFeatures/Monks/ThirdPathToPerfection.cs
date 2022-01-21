using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Entities;

using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Effects;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.ClassFeatures.Monks
{
    public class ThirdPathToPerfection : Template
    {
        public static readonly Guid ID = Guid.Parse("b367a8a0-591a-4b15-ad4d-719cca4ccc14");

        protected override ClassFeature GetClassFeature()
        {
            return new ClassFeature
            {
                Id = ID, 
                Level = 15,
                Name = "Third Path to Perfection", 
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("8c28721e-25ea-4bea-88ae-381dcea57edd"), Type = TextBlockType.Text, Text = "You have made great progress in your personal studies of enlightenment. Choose one of the saving throws you selected for path to perfection or second path to perfection. Your proficiency rank for the chosen type of save increases to legendary. When you roll a critical failure on the chosen type of save, you get a failure instead. When you roll a failure on the chosen type of save against an effect that deals damage, you take half damage." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add effects.
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("70900040-3dea-482d-823d-85992550a190"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = 157
            };
        }
    }
}
