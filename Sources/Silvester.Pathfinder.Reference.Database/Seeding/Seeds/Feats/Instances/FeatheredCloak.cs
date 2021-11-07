using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class FeatheredCloak : Template
    {
        public static readonly Guid ID = Guid.Parse("0a1d2edc-fe44-49a6-821f-43a65ed2cfb4");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Feathered Cloak",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("524e8f96-10be-432a-9fe5-149c8c0156bd"), Type = TextBlockType.Text, Text = "To blend in with the grounded and wingless, you fold your wings just so on your back, creating the illusion of a feathered cloak. You receive a +2 circumstance bonus to Deception checks to (action: Impersonate) a version of yourself who is not a strix." };
            yield return new TextBlock { Id = Guid.Parse("f6aa0dc5-2b30-4497-9f1c-9416708015fe"), Type = TextBlockType.Text, Text = "Additionally, your folded wings help you obscure objects on your person, providing a +2 circumstance bonus to Stealth checks to (action: Conceal an Object)." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d8710f39-8350-4cf4-a512-89a26accb756"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
