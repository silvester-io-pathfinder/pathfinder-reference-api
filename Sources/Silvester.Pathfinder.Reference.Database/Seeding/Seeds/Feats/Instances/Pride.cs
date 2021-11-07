using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Pride : Template
    {
        public static readonly Guid ID = Guid.Parse("c22a9d30-d375-4d59-95e5-c9b0ed3f3656");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Pride",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c0e4e1b7-aaed-4802-b939-4730d39957f3"), Type = TextBlockType.Text, Text = "All is well as long as you appear well, but you get caught up in the moment and lose track of what’s important." };
            yield return new TextBlock { Id = Guid.Parse("b7a89df6-909c-4efa-85ad-b1e4150502d7"), Type = TextBlockType.Text, Text = "~ Catharsis Trigger: You critically fail on an attack roll or saving throw." };
            yield return new TextBlock { Id = Guid.Parse("1231f9b4-ae68-4cfc-897c-90f781c38765"), Type = TextBlockType.Text, Text = "~ Catharsis Activation: The critical failure becomes a failure." };
            yield return new TextBlock { Id = Guid.Parse("16bcf58e-5397-4870-b5c9-38bc2a1face0"), Type = TextBlockType.Text, Text = "~ Emotional Fervor: Each time you cast an illusion spell, until the start of your next turn, any critical failure you roll on an attack roll or saving throw is a failure instead. Spell: (spell: color spray)" };
            yield return new TextBlock { Id = Guid.Parse("878a2153-ebca-45ef-aadf-94798ad6825f"), Type = TextBlockType.Text, Text = "~ Emotional Fallout: You momentarily lose track of what’s real, becoming confused for 1 round. Spell: (spell: mirror image)" };
            yield return new TextBlock { Id = Guid.Parse("ac810d2b-dfe8-4091-8284-e13070f70380"), Type = TextBlockType.Text, Text = "~ Focus Spell: (spell: veil of confidence)" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("418ae349-e015-45ab-a1bd-89008ebfccca"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
