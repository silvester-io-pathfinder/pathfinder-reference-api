using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonSpit : Template
    {
        public static readonly Guid ID = Guid.Parse("272b364c-9bb8-4a77-b677-39f7360882f6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dragon Spit",
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
            yield return new TextBlock { Id = Guid.Parse("2f4de08b-17bc-47cb-803d-5fd387ce2680"), Type = TextBlockType.Text, Text = "Many of your people claim to have dragon blood in their veins, and in your case, this is true – you can spit energy, and you might have an especially visible sign of your draconic heritage. Choose one of the following cantrips: (spell: acid splash), (spell: electric arc), (spell: produce flame), or (spell: ray of frost). You can cast this spell as an innate arcane spell at will, and when you cast it, the spell’s energy emerges from your mouth." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("57bbbaa1-3f63-45ec-9912-c99e35c15fb4"), "Tian-Dan Ethnicity");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7178c3b-4289-45a8-a42b-4cbea7522385"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
