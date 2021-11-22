using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DomainInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("34de68c0-df7c-41f9-b479-83c651ae7eb8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Domain Initiate",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = true,
                Special = "You can select this feat multiple times, selecting a different domain each time and gaining its domain spell.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("b847c2a1-4967-4d4c-a395-1008ce2bb667"), Type = TextBlockType.Text, Text = "Your deity bestows a special spell related to their powers. Select one domain – a subject of particular interest to you within your religion – from your deity's list. You gain an initial domain spell for that domain, a spell unique to the domain and not available to other clerics." };
            yield return new TextBlock { Id = Guid.Parse("32f96044-cc98-4675-8762-bc75cb9613df"), Type = TextBlockType.Text, Text = "Domain spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the (action: Refocus) activity to pray to your deity or do service toward their causes." };
            yield return new TextBlock { Id = Guid.Parse("84007a6b-8824-4baa-9704-9f45fdf90b1e"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Focus spells don't require spell slots, nor can you cast them using spell slots. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. The full rules for focus spells appear on page 300." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9d439b43-31f3-4a9d-934f-5ee3eaa3f347"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
