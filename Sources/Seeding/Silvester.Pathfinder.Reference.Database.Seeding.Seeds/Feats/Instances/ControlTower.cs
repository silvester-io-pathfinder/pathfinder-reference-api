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
    public class ControlTower : Template
    {
        public static readonly Guid ID = Guid.Parse("d04e605d-4c11-4725-88e1-785491bbe3a2");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Control Tower",
                Level = 14,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ffa693f3-c1c0-4080-94eb-49a7d9055e29"), Type = TextBlockType.Text, Text = $"Your keen senses and ability to process battlefield information have dramatically improved, allowing you to drastically reduce the advantage of unseen foes. You and allies in your overwatch field gain a +2 circumstance bonus when using the {ToMarkdownLink<Models.Entities.Action>("Seek", Actions.Instances.Seek.ID)} action to find hidden or undetected creatures within the overwatch field. You and your allies don't have to succeed at a flat check to target a concealed creature within your overwatch field. When you or an ally targets a hidden creature in your overwatch field, reduce the DC of the flat check to 5." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("82addff1-0c99-4ff4-a9b7-7185cb610ebd"), Feats.Instances.OverwatchDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("03bca327-a02c-4a37-9e02-e648a1f0705b"), Proficiencies.Instances.Master.ID, Skills.Instances.Perception.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3f6324c5-9912-4370-a631-87a26216eba3"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
