using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DutifulRetaliation : Template
    {
        public static readonly Guid ID = Guid.Parse("9a5c364c-be80-409a-bd64-7f4695e793bf");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dutiful Retaliation",
                Level = -1,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An enemy within 15 feet of you hits you with a Strike and deals damage to you.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e94bf25b-70c0-47f2-978b-de8b312de6ca"), Type = TextBlockType.Text, Text = "Your eidolon instinctively flashes with ectoplasmic energy, allowing them to strike back against an enemy who dares to harm you. Your eidolon makes a melee unarmed (action: Strike) against the triggering enemy, even if that enemy isn’t within your eidolon’s reach." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("be207791-336b-4ee9-a3a0-483ac58fa8bd"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
