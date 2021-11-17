using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarGold : Template
    {
        public static readonly Guid ID = Guid.Parse("21a7b528-0c2c-4462-be0d-d35315ee7b35");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draconic Exemplar - Gold",
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
            yield return new TextBlock { Id = Guid.Parse("37fe1e11-f9ef-4fb7-8f26-91e7449e0bb6"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a gold dragon." };
            yield return new TextBlock { Id = Guid.Parse("c0b0f3ae-5093-4a82-a225-ff1fa0bef96e"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Cone" };
            yield return new TextBlock { Id = Guid.Parse("fe6449aa-8a3f-430a-8d1b-9c2421591a2b"), Type = TextBlockType.Text, Text = "~ Damage Type: Fire" };
            yield return new TextBlock { Id = Guid.Parse("a41b5a79-e946-43fa-980f-966ac671fca8"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f4e88f53-532a-4de2-89bc-0d4239974316"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
