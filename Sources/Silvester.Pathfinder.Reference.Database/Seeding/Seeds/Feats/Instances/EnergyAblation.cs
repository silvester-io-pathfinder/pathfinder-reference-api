using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EnergyAblation : Template
    {
        public static readonly Guid ID = Guid.Parse("cbeac681-ade9-47d6-821b-2a3bfc49ba93");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Energy Ablation",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("852ef463-5c7d-4f7a-8150-1bf579f30e7c"), Type = TextBlockType.Text, Text = "When you cast energy spells, you retain some of that energy as a protective barrier. If your next action is to (activity: Cast a Spell) that deals energy damage, whether or not it successfully deals damage, you gain resistance to that type of energy equal to the spell’s level (minimum 1) until the end of your next turn. If the spell deals more than one type of energy damage, choose one and gain resistance to that type." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("39a97e73-0f28-4c13-bb9a-b4a433d0f221"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
