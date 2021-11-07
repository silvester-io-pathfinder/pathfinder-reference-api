using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MagicalAdept : Template
    {
        public static readonly Guid ID = Guid.Parse("878cd8bf-485d-41cb-b181-b8b784f3799d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Magical Adept",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("f1642edb-a041-4f78-a395-bc557799f035"), Type = TextBlockType.Text, Text = "Your eidolon gains more magic. Choose one 2nd-level spell and one 1st-level spell of your eidolon’s tradition. Your eidolon can cast them each once per day as innate spells. At every even level after you take this feat, your eidolon can swap one of these innate spells for a new innate spell that’s 2 or more levels lower than your highest-level spell slot." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("e4cabc55-c61c-4099-9f60-6be58c01bf0d"), Feats.Instances.MagicalUnderstudy.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("293d3826-efad-4325-b843-3c3b9da702e1"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
