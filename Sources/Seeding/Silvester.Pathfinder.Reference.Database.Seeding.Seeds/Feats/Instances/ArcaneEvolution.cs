using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("6c481434-498c-4dbc-b3db-86943979be9d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Arcane Evolution",
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
            yield return new TextBlock { Id = Guid.Parse("9327d946-7efa-4b4e-a8d6-eb36de1ef249"), Type = TextBlockType.Text, Text = $"Your arcane legacy grants you an exceptional aptitude for intellectual and academic pursuits. You become trained in one skill of your choice. Additionally, you keep a book of arcane spells similar to a wizard's {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}. You add all the spells in your spell repertoire to this book for free, and you can add additional arcane spells to the book by paying the appropriate cost and using your Arcana skill, similarly to how a wizard can {ToMarkdownLink<Models.Entities.SkillAction>("Learn Spells", SkillActions.Instances.LearnASpell.ID)} to add those spells to their {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("spellbook", Items.AdventuringGears.Instances.Spellbook.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("79f7aa3e-db84-447c-878d-643f90e68261"), Type = TextBlockType.Text, Text = $"During your daily preparations, choose any one spell from your book of arcane spells. If it isn't in your spell repertoire, add it to your spell repertoire until the next time you prepare. If it's already in your spell repertoire, add it as an additional signature spell for that day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("c1b35755-8edd-4f0e-8aa1-79fc2354f323"), MagicTraditions.Instances.Arcane.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("60090ed7-ec99-4784-b7d4-403ee34915f4"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
