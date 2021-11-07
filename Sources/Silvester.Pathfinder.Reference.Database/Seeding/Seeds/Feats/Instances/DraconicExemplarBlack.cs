using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBlack : Template
    {
        public static readonly Guid ID = Guid.Parse("d93c7953-af3a-44f6-8bd4-43876abf3ad4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Black",
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
            yield return new TextBlock { Id = Guid.Parse("8288543a-4742-425e-8d71-6dbff167f9fa"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a black dragon." };
            yield return new TextBlock { Id = Guid.Parse("dae0d1d4-ba4c-478a-9064-07e60907f48b"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("76ab9b06-52d1-4afb-b2f5-c98f9a745e6a"), Type = TextBlockType.Text, Text = "~ Damage Type: Acid" };
            yield return new TextBlock { Id = Guid.Parse("c8abb096-78d5-4bc6-8793-8bc25be39bf9"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f6593712-550b-4cb9-b758-4816a309ef26"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
