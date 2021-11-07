using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnleashFocusedIntent : Template
    {
        public static readonly Guid ID = Guid.Parse("49b9a75f-e69d-4a4e-9f40-aa289ede8543");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unleash Focused Intent",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("2ba0a1d9-e5eb-4a41-af0c-be0c4b9501b7"), Type = TextBlockType.Text, Text = "After some time of acclimating to a stressful situation, your psychic magic flares to greater destructive power." };
            yield return new TextBlock { Id = Guid.Parse("1febc53c-5911-4381-bb3a-65f324221e26"), Type = TextBlockType.Text, Text = "~ Benefit: When you (action: Cast a Spell) from your spell slots while you have Unleashed Focused Intent, you gain a status bonus to that spell’s damage equal to double the spell’s level as long as spell deals damage and doesn’t have a duration." };
            yield return new TextBlock { Id = Guid.Parse("196acb5c-fcc9-476d-89fb-94d4237853d4"), Type = TextBlockType.Text, Text = "~ Drawback: The focus on offense comes at the expense of your defensive instincts. You take a –2 penalty to AC while you’ve Unleashed Focused Intent." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("b4344bbf-7b03-438f-ac36-870eea4c65be"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
