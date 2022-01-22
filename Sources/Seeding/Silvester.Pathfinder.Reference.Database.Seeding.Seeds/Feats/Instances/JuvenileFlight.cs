using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class JuvenileFlight : Template
    {
        public static readonly Guid ID = Guid.Parse("1dc26587-d6fc-48ab-8d8e-6b17ae207d6a");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Juvenile Flight",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("dbc5124b-a45e-4382-b895-301adbc905f7"), Type = TextBlockType.Text, Text = $"You unfold your wings for travel and can keep them unfolded for 10 minutes. You gain a fly Speed equal to your land Speed while your wings are unfurled. If you have {ToMarkdownLink<Models.Entities.Feat>("Fledgling Flight", Feats.Instances.FledglingFlight.ID)}, you gain a +10-foot status bonus to your fly Speed with Juvenile Flight. As normal, since your fly Speed is derived from your land Speed, this status bonus isn't cumulative with a status bonus to your land Speed, if you have one." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2405705b-386c-4809-ac63-d0267ff4846a"),
                SourceId = Sources.Instances.LostOmensAncestryGuide.ID,
                Page = -1
            };
        }
    }
}
