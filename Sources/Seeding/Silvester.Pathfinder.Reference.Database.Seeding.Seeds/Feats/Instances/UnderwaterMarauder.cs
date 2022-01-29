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
    public class UnderwaterMarauder : Template
    {
        public static readonly Guid ID = Guid.Parse("ae454a88-be10-4807-ba26-2c78cde10523");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Underwater Marauder",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("eabc47ea-7e99-425a-a5ab-8bf15f522c41"), Type = TextBlockType.Text, Text = $"You've learned to fight underwater. You are not flat-footed while in water, and you don't take the usual penalties for using a bludgeoning or slashing melee weapon in water." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("8d588d9b-5967-46f7-b03e-350476323f21"), Proficiencies.Instances.Trained.ID, Skills.Instances.Athletics.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("6089a14c-126a-40d5-b05c-156e22e03a09"), Traits.Instances.General.ID);
            builder.Add(Guid.Parse("bd51fd86-ccd1-4b07-a203-1c641d7e3524"), Traits.Instances.Skill.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e7d4fc61-1714-4ed1-a95c-b0014717a421"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
