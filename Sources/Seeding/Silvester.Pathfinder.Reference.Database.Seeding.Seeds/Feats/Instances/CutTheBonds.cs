using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CutTheBonds : Template
    {
        public static readonly Guid ID = Guid.Parse("db87edfd-0558-45d6-a82e-623a4dfacb27");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cut the Bonds",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ddcaf719-ca9c-4b69-9608-386ac435e7ea"), Type = TextBlockType.Text, Text = $"Select a magical effect that has made an adjacent member of your crop clumsy, grabbed, paralyzed, restrained, or slowed. Attempt a counteract check using your attack modifier (including your multiple attack penalty) with a melee weapon with which you have expert proficiency. Your counteract level is half your level rounded up. On a success, you free that member from the effect; on a failure, you can't attempt to use Cut the Bonds on that effect on that crop member until 24 hours have passed." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("b5778e6a-f7e4-4ac0-9393-264febf60fb4"), Feats.Instances.BellflowerTillerDedication.ID);
            builder.HaveAnyMeleeWeaponSpecificProficiency(Guid.Parse("ae5edd25-c746-4f93-9d5c-767d707e9872"), Proficiencies.Instances.Expert.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("c32774c7-6685-4e15-acb6-a1496c71a251"), Traits.Instances.Archetype.ID);
            builder.Add(Guid.Parse("9ed43013-0f86-48c9-b715-4682c3b37366"), Traits.Instances.Attack.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("73e6b231-eb0c-46fc-a715-500380b4269b"),
                SourceId = Sources.Instances.AgeOfAshes.ID,
                Page = -1
            };
        }
    }
}
