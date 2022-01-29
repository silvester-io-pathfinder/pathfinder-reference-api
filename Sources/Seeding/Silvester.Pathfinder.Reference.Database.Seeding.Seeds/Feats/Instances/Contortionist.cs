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
    public class Contortionist : Template
    {
        public static readonly Guid ID = Guid.Parse("f179fd1b-90f2-4663-82ad-89f68f17e07b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Contortionist",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("038cea03-8638-40d1-85e4-843030e567b7"), Type = TextBlockType.Text, Text = $"You can squeeze out of tight situations surprisingly quickly, gaining an advantage against foes that try to pin you down. You gain the {ToMarkdownLink<Models.Entities.Feat>("Quick Squeeze", Feats.Instances.QuickSqueeze.ID)} skill feat, and if you're a master in Acrobatics, you can {ToMarkdownLink<Models.Entities.SkillAction>("Squeeze", SkillActions.Instances.Squeeze.ID)} at full Speed. Whenever you successfully {ToMarkdownLink<Models.Entities.Action>("Escape", Actions.Instances.Escape.ID)} using Acrobatics, the creature you {ToMarkdownLink<Models.Entities.Action>("Escaped", Actions.Instances.Escape.ID)} from is flat-footed against the next attack you make against it before the end of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("6b886a2d-d143-42ab-a2b9-e39c377e0f3b"), Feats.Instances.AcrobatDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be6d05e0-4e2c-4b33-8894-ccb13426963b"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
