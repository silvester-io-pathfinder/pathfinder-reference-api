using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Ancestries.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class WindwebGrippli : Template
    {
        public static readonly Guid ID = Guid.Parse("2cd033be-8e4a-4c66-96a2-cdf2dac7a8d2");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Windweb Grippli"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("f2cf0f43-214a-4e3a-8d1e-125beb56ab26"), Type = TextBlockType.Text, Text = "Tough webbing along your hands and toes can slow any fall. As long as you have one hand free, you take no falling damage, regardless of the distance you fall." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            //TODO: Add free-hand requirement.
            builder.ModifyFallDistance(Guid.Parse("611c2ef2-279c-4ab9-bc1d-86e48fac8a05"), ModifierType.Multiply, modifier: 0);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4301ddfc-d123-44ce-823d-83c3d89234d3"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 119
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Grippli.ID;
        }
    }
}
