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
    public class LaughingGnoll : Template
    {
        public static readonly Guid ID = Guid.Parse("6e428d53-31e7-4944-b4f9-874f6ef8c7de");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Laughing Gnoll",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9b1f8109-2079-429c-b6e5-b40e2e353506"), Type = TextBlockType.Text, Text = $"A gnoll's sinister giggle is a sound of warning and threat. You gain the {ToMarkdownLink<Models.Entities.Feat>("Battle Cry", Feats.Instances.BattleCry.ID)} skill feat. You don't take a penalty when you attempt to {ToMarkdownLink<Models.Entities.SkillAction>("Demoralize", SkillActions.Instances.Demoralize.ID)} a creature that doesn't understand your language." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("717d7b5f-a48c-4424-8793-e25bcf868297"), Proficiencies.Instances.Master.ID, Skills.Instances.Intimidation.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("bbaaaeb9-8227-4a37-9738-c40f7e1bc49d"), Traits.Instances.Gnoll.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("07610249-b5e9-406d-9cde-2e55427f0964"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
