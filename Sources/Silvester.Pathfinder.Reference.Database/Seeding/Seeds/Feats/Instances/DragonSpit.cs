using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DragonSpit : Template
    {
        public static readonly Guid ID = Guid.Parse("c8d86308-a54b-415e-8399-88365d083d3d");

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
            yield return new TextBlock { Id = Guid.Parse("ad8e36de-8d18-4f73-af05-d98cadfab44a"), Type = TextBlockType.Text, Text = "Many of your people claim to have dragon blood in their veins, and in your case, this is true – you can spit energy, and you might have an especially visible sign of your draconic heritage. Choose one of the following cantrips: (spell: acid splash), (spell: electric arc), (spell: produce flame), or (spell: ray of frost). You can cast this spell as an innate arcane spell at will, and when you cast it, the spell’s energy emerges from your mouth." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.Manual(Guid.Parse("6970ddae-f9e1-493b-a781-86cb79b1a1c2"), "Tian-Dan Ethnicity");
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("612d3706-89ed-416d-ad09-fcef39b1efd8"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
