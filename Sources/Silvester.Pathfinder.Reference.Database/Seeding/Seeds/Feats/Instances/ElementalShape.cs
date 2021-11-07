using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElementalShape : Template
    {
        public static readonly Guid ID = Guid.Parse("71f4296a-0346-4618-bf33-bb6119f812d1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Elemental Shape",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d0859f9e-3394-4045-bd31-b0a54fed04c9"), Type = TextBlockType.Text, Text = "You understand the fundamental elements of nature such that you can imbue them into your body and manifest as a living embodiment of those elements. Add the forms in (Spell: elemental form) to your wild shape list. Whenever you’re polymorphed into another form using (Spell: wild shape), you gain resistance 5 to fire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("44ff1a79-b652-4557-ab22-eaeb4bdfe318"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("360f65af-ef49-4eae-a630-77d80fdd502d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
