using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DomainInitiate : Template
    {
        public static readonly Guid ID = Guid.Parse("b4744a30-59f3-4eca-ad32-3912026a90c8");

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
            yield return new TextBlock { Id = Guid.Parse("d975a544-adb1-40dd-ba40-91baa4ae5782"), Type = TextBlockType.Text, Text = "Your deity bestows a special spell related to their powers. Select one domain – a subject of particular interest to you within your religion – from your deity’s list. You gain an initial domain spell for that domain, a spell unique to the domain and not available to other clerics." };
            yield return new TextBlock { Id = Guid.Parse("a63ec4e8-2bd0-4f2c-a712-b677a0855da4"), Type = TextBlockType.Text, Text = "Domain spells are a type of focus spell. It costs 1 Focus Point to cast a focus spell, and you start with a focus pool of 1 Focus Point. You refill your focus pool during your daily preparations, and you can regain 1 Focus Point by spending 10 minutes using the (action: Refocus) activity to pray to your deity or do service toward their causes." };
            yield return new TextBlock { Id = Guid.Parse("2682f708-6bf0-4b1f-9948-6b2b38af5f07"), Type = TextBlockType.Text, Text = "Focus spells are automatically heightened to half your level rounded up. Focus spells don’t require spell slots, nor can you cast them using spell slots. Certain feats can give you more focus spells and increase the size of your focus pool, though your focus pool can never hold more than 3 Focus Points. The full rules for focus spells appear on page 300." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("110ddf8c-c614-42c0-95df-981080f4158f"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
