using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ArcaneEvolution : Template
    {
        public static readonly Guid ID = Guid.Parse("060e2e38-389b-44f1-b6c3-bb9fa9383fb7");

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
            yield return new TextBlock { Id = Guid.Parse("f4711480-96ac-41fd-8577-b0c9d4f6e4cc"), Type = TextBlockType.Text, Text = "Your arcane legacy grants you an exceptional aptitude for intellectual and academic pursuits. You become trained in one skill of your choice. Additionally, you keep a book of arcane spells similar to a wizard’s (item: spellbook). You add all the spells in your spell repertoire to this book for free, and you can add additional arcane spells to the book by paying the appropriate cost and using your Arcana skill, similarly to how a wizard can (action: Learn Spells | Learn a Spell) to add those spells to their (item: spellbook)." };
            yield return new TextBlock { Id = Guid.Parse("0d382c11-9472-4395-8d84-41e4b513ea32"), Type = TextBlockType.Text, Text = "During your daily preparations, choose any one spell from your book of arcane spells. If it isn’t in your spell repertoire, add it to your spell repertoire until the next time you prepare. If it’s already in your spell repertoire, add it as an additional signature spell for that day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificBloodlineTradition(Guid.Parse("78cee19a-bd90-4cec-ab65-15fd7a04086c"), Bloodlines.Instances.Arcane.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("43855a99-7729-4dfd-8ce1-2c893bd37b9d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
