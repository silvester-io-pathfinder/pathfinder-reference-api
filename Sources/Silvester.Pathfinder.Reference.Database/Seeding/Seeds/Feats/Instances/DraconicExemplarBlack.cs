using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DraconicExemplarBlack : Template
    {
        public static readonly Guid ID = Guid.Parse("24ca2be7-4057-4a5e-9f2a-cf78cf0245c7");

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
            yield return new TextBlock { Id = Guid.Parse("7da70b45-7f7d-42c3-9bf0-dcb4ff43d80d"), Type = TextBlockType.Text, Text = "Your scale color and appearance resembles that of a black dragon." };
            yield return new TextBlock { Id = Guid.Parse("7c008202-eb04-4715-8f41-acbccbc9f9bc"), Type = TextBlockType.Text, Text = "~ Breath Weapon Shape: Line" };
            yield return new TextBlock { Id = Guid.Parse("e1e9f5c9-3b7e-4f8b-aba0-d468e4b9c99e"), Type = TextBlockType.Text, Text = "~ Damage Type: Acid" };
            yield return new TextBlock { Id = Guid.Parse("d9865b37-8483-4f21-97ee-800c190bd343"), Type = TextBlockType.Text, Text = "~ Saving Throw: Reflex" };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("82b9677d-69ea-4c1e-a05a-72e1be790177"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
