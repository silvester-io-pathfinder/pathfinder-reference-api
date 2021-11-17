using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Builders;
using Silvester.Pathfinder.Reference.Database.Effects.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Heritages.Instances
{
    public class SpindlyAnadi : Template
    {
        public static readonly Guid ID = Guid.Parse("02969289-7489-44dd-8f21-11e0367cb222");

        protected override Heritage GetHeritage()
        {
            return new Heritage 
            { 
                Id = ID, 
                RarityId = Rarities.Instances.Common.ID, 
                Name = "Spindly Anadi"
            };
        }

        protected override IEnumerable<TextBlock> GetDetails()
        {
            yield return new TextBlock { Id = Guid.Parse("ab75e15e-8859-4b46-b4da-abab17d91cdb"), Type = TextBlockType.Text, Text = "Your limbs are exceptionally long in both forms, allowing you to skitter about with surprising agility. Your Speed increases from 25 to 30 feet." };
        }

        protected override void GetEffects(BooleanEffectBuilder builder)
        {
            builder.ModifySpecificSpeed(Guid.Parse("54a7fef5-d943-4675-b292-f32f53c1b197"), MovementMethod.Walking, ModifierType.Add, modifier: 5);
        }

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("365d0b23-fc6e-4672-a820-e68264cfd95f"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = 103
            };
        }

        protected override IEnumerable<Guid> GetAncestries()
        {
            yield return Ancestries.Instances.Anadi.ID;
        }
    }
}
