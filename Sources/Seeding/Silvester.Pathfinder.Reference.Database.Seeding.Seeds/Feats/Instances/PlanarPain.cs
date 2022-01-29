using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class PlanarPain : Template
    {
        public static readonly Guid ID = Guid.Parse("46a921bc-ee10-49e7-ab95-0f6232ab5caa");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Planar Pain",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eaf02835-72c1-4461-8f1c-ea8e67dfbee4"), Type = TextBlockType.Text, Text = $"When you manifest the essence form, choose one damage type: acid, chaotic, cold, electricity, evil, fire, good, lawful, negative, positive, or sonic. Attacks with the weapon deal this type of damage instead of their physical damage with a +2 status bonus to the damage." };
            yield return new TextBlock { Id = Guid.Parse("858cbe43-942c-4c4f-8e83-2f12f5b8407e"), Type = TextBlockType.Text, Text = $"__Corruption Flaw__ When you deal damage with a weapon or unarmed attack, you take 2 damage of the last type you chose for planar pain, even if the damage type normally wouldn't harm you, such as good damage if you aren't evil." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            //TODO: Add prerequisites.
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bda5b136-d70b-40a0-9186-7e77a29e2942"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
