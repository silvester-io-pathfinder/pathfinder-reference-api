using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DuelistsChallenge : Template
    {
        public static readonly Guid ID = Guid.Parse("a4b53fe1-2e11-41dc-b93a-b0dadc6f51dc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Duelist's Challenge",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("09ff458f-92b0-4891-8903-99d80e8f0142"), Type = TextBlockType.Text, Text = $"Select one foe that you can see and proclaim a challenge. That foe is your dueling opponent until they are defeated, flee, or the encounter ends. Any time you hit that enemy using a single one-handed melee weapon while your other hand or hands are free, you gain a circumstance bonus to the {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}'s damage equal to the number of damage dice your weapon deals." };
            yield return new TextBlock { Id = Guid.Parse("1422ea38-2d36-479f-9cda-cf9ca4b524f0"), Type = TextBlockType.Text, Text = $"If you attack a creature other than your dueling opponent, you take a circumstance penalty to damage equal to the number of damage dice your weapon deals." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("be0243f0-eaf0-43ed-8659-c128e6c00751"), Feats.Instances.DuelistDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6a5b4ef9-d61a-44a5-b85c-fe6dbd07f683"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
