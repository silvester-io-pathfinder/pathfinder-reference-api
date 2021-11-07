using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VersatileSignature : Template
    {
        public static readonly Guid ID = Guid.Parse("c8a4833e-2328-401a-a7af-51dc4499e5a8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Versatile Signature",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("4e3b7693-7062-46e6-bbae-212ebcdfc5a6"), Type = TextBlockType.Text, Text = "While most bards are known for certain signature performances and spells, you’re always tweaking your available repertoire. When you make your daily preparations, you can change one of your signature spells to a different spell of that level from your repertoire." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificMuse(Guid.Parse("aca5a0ae-5697-4452-9699-5c60200471d2"), Muses.Instances.Polymath.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0d01c7df-0186-449c-9a0a-f2291a1b036a"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
